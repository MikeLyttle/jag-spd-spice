﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using Gov.Jag.Spice.Interfaces.SharePoint;
using Gov.Lclb.Cllb.Interfaces.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SpiceCarlaSync;
using SpiceCarlaSync.models;
using Microsoft.Rest;

namespace Gov.Lclb.Cllb.Interfaces
{
    public class FileSystemItem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string documenttype { get; set; }
        public int size { get; set; }
        public string serverrelativeurl { get; set; }
        public DateTime timecreated { get; set; }
        public DateTime timelastmodified { get; set; }
    }

    public class CarlaSharepoint
    {
        const string DOCUMENT_LIBRARY = "SPD Applications";
        const string REQUESTS_PATH = "Requests";
        const string RESULTS_PATH = "Results";
        const string APPLICATIONS_PATH = "businesses";
        const string ASSOCIATES_PATH = "associates";
        const string WORKERS_PATH = "workers";

        public ILogger _logger { get; }
        private IConfiguration _configuration { get; }
        public FileManager _sharepoint;
        public CarlaClient _carlaClient;

        public CarlaSharepoint(IConfiguration Configuration, ILoggerFactory loggerFactory, FileManager sharepoint, CarlaClient carla)
        {
            _configuration = Configuration;
            _sharepoint = sharepoint;
            _logger = loggerFactory.CreateLogger(typeof(CarlaSharepoint));
            _carlaClient = carla;
            SetupSharepointFolders();
        }

        public async void SetupSharepointFolders()
        {
            try
            {
                var documentLibraryExists = await _sharepoint.DocumentLibraryExists(DOCUMENT_LIBRARY);
                if (!documentLibraryExists)
                {
                    _logger.LogInformation("Creating document library.");
                    await _sharepoint.CreateDocumentLibrary(DOCUMENT_LIBRARY);
                }

                var requestsFoldersExist = await _sharepoint.FolderExists(DOCUMENT_LIBRARY, REQUESTS_PATH);
                if (!requestsFoldersExist)
                {
                    _logger.LogInformation("Creating request document folders.");
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, REQUESTS_PATH);
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, REQUESTS_PATH + "/" + APPLICATIONS_PATH);
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, REQUESTS_PATH + "/" + ASSOCIATES_PATH);
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, REQUESTS_PATH + "/" + WORKERS_PATH);
                }


                var resultsFoldersExist = await _sharepoint.FolderExists(DOCUMENT_LIBRARY, RESULTS_PATH);
                if (!resultsFoldersExist)
                {
                    _logger.LogInformation("Creating result document folders.");
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, RESULTS_PATH);
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, RESULTS_PATH + "/" + APPLICATIONS_PATH);
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, RESULTS_PATH + "/" + ASSOCIATES_PATH);
                    await _sharepoint.CreateFolder(DOCUMENT_LIBRARY, RESULTS_PATH + "/" + WORKERS_PATH);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error creating sharepoint document library and folders");
                _logger.LogError("Exception Message: " + ex.Message);
            }
        }

        /// <summary>
        /// Import requests to LCRB SharePoint
        /// </summary>
        /// <returns>success, business file path, associates file path</returns>
        public async Task<(bool, string, string)> SendApplicationRequestsToSharePoint(List<IncompleteApplicationScreening> requests)
        {
            int suffix = (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            bool resp = false;
            string associatesFilepath = "";
            string businessFilepath = "";
            foreach (var request in requests)
            {
                List<CsvAssociateExport> associateExports = CsvAssociateExport.CreateListFromRequest(request);
                List<CsvBusinessExport> businessExports = new List<CsvBusinessExport>
                {
                    CsvBusinessExport.CreateFromRequest(request)
                };

                using (var mem = new MemoryStream())
                using (var writer = new StreamWriter(mem))
                using (var csvWriter = new CsvWriter(writer))
                {
                    csvWriter.Configuration.HasHeaderRecord = true;
                    csvWriter.Configuration.RegisterClassMap<CsvAssociateExportMap>();

                    csvWriter.WriteHeader<CsvAssociateExport>();
                    csvWriter.NextRecord();
                    csvWriter.WriteRecords(associateExports);

                    writer.Flush();
                    mem.Position = 0;

                    try
                    {
                        _logger.LogInformation("Uploading business associates CSV.");
                        (resp, associatesFilepath) = await _sharepoint.UploadFile($"{request.RecordIdentifier}_{request.Establishment.Name}_associates_{suffix}.csv", DOCUMENT_LIBRARY, REQUESTS_PATH + "/" + ASSOCIATES_PATH, mem, "text/csv");
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("Error uploading business associates CSV to sharepoint");
                        _logger.LogError("Error: " + ex.Message);
                        return (false, "", "");
                    }
                }

                using (var mem = new MemoryStream())
                using (var writer = new StreamWriter(mem))
                using (var csvWriter = new CsvWriter(writer))
                {
                    csvWriter.Configuration.HasHeaderRecord = true;
                    csvWriter.Configuration.RegisterClassMap<CsvBusinessExportMap>();

                    csvWriter.WriteHeader<CsvBusinessExport>();
                    csvWriter.NextRecord();
                    csvWriter.WriteRecords(businessExports);

                    writer.Flush();
                    mem.Position = 0;

                    try
                    {
                        _logger.LogInformation("Uploading business application CSV.");
                        (resp, businessFilepath) = await _sharepoint.UploadFile($"{request.RecordIdentifier}_{request.Establishment.Name}_business_{suffix}.csv", DOCUMENT_LIBRARY, REQUESTS_PATH + "/" + APPLICATIONS_PATH, mem, "text/csv");
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("Error uploading business application CSV to sharepoint");
                        _logger.LogError("Error: " + ex.Message);
                        return (false, "", "");
                    }
                }
            }
            return (resp, businessFilepath, associatesFilepath);
        }

        /// <summary>
        /// Sends the worker requests to share point.
        /// </summary>
        /// <returns>The worker requests to share point.</returns>
        /// <param name="requests">Requests.</param>
        public async Task<(bool, string)> SendWorkerRequestsToSharePoint(List<IncompleteWorkerScreening> requests)
        {
            int suffix = (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            List<CsvWorkerExport> workersExports = new List<CsvWorkerExport>();
            string workerfilePrefix = "";
            foreach (var request in requests)
            {
                workersExports.Add(CsvWorkerExport.CreateFromRequest(request));
                workerfilePrefix = request.Contact?.SpdJobId + "_" + request.Contact?.LastName;
            }

            using (var mem = new MemoryStream())
            using (var writer = new StreamWriter(mem))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.RegisterClassMap<CsvWorkerExportMap>();

                csvWriter.WriteHeader<CsvWorkerExport>();
                csvWriter.NextRecord();
                csvWriter.WriteRecords(workersExports);

                writer.Flush();
                mem.Position = 0;

                try
                {
                    _logger.LogInformation("Uploading workers CSV.");
                    return await _sharepoint.UploadFile($"{workerfilePrefix}_workers_{suffix}.csv", DOCUMENT_LIBRARY, REQUESTS_PATH + "/" + WORKERS_PATH, mem, "text/csv");
                }
                catch (Exception ex)
                {
                    _logger.LogError("Error uploading workers CSV to sharepoint");
                    _logger.LogError("Error: " + ex.Message);
                    return (false, "");
                }
            }
        }

        /// <summary>
        /// Processes the results folders and sends new results to Carla for updating
        /// </summary>
        public async Task ProcessResultsFolders()
        {
            // Process application screening results
            List<FileSystemItem> businessFiles = await getFileDetailsListInFolder(DOCUMENT_LIBRARY, RESULTS_PATH + "/" + APPLICATIONS_PATH);
            List<FileSystemItem> associatesFiles = await getFileDetailsListInFolder(DOCUMENT_LIBRARY, RESULTS_PATH + "/" + ASSOCIATES_PATH);
            List<CompletedApplicationScreening> applicationResponses = await ProcessApplicationResults(businessFiles, associatesFiles);
            if(applicationResponses.Count > 0)
            {
                try
                {
                    await _carlaClient.ApplicationScreenings.POSTWithHttpMessagesAsync(applicationResponses);
                }
                catch (HttpOperationException httpOperationException)
                {
                    _logger.LogError(httpOperationException, "Failed to send application results to Carla.");
                    _logger.LogError(httpOperationException.Response.Content);
                }
            }

            // Process worker screening results
            List<FileSystemItem> workerFiles = await getFileDetailsListInFolder(DOCUMENT_LIBRARY, RESULTS_PATH + "/" + WORKERS_PATH);
            List<CompletedWorkerScreening> workerResponses = await ProcessWorkerResults(workerFiles);
            if(workerResponses.Count > 0)
            {
                try
                {
                    await _carlaClient.WorkerScreenings.POSTWithHttpMessagesAsync(workerResponses);
                }
                catch (HttpOperationException httpOperationException)
                {
                    _logger.LogError(httpOperationException, "Failed to send worker results to Carla.");
                    _logger.LogError(httpOperationException.Response.Content);
                }
            }
        }

        private async Task<List<CompletedWorkerScreening>> ProcessWorkerResults(List<FileSystemItem> workerFiles)
        {
            List<CompletedWorkerScreening> responses = new List<CompletedWorkerScreening>();
            // look for unprocessed response files
            _logger.LogInformation("Looking for unprocessed worker response files.");
            var unprocessedFiles = workerFiles.Where(f => !f.name.StartsWith("processed_")).ToList();
            foreach(var file in unprocessedFiles)
            {
                if (Path.GetExtension(file.name).ToLower() != ".csv")
                {
                    _logger.LogError($"Worker results file found but not of type csv.");
                    continue;
                }

                // Download file
                _logger.LogError("Worker file found. Downloading files.");
                byte[] fileContents = await _sharepoint.DownloadFile(file.serverrelativeurl);

                // Parse file and add to responses list for further processing
                _logger.LogError("Updating worker screening result.");
                string workerData = System.Text.Encoding.Default.GetString(fileContents);

                List<CompletedWorkerScreening> currentResponses = ParseWorkerResponse(workerData);
                responses.AddRange(currentResponses);
                
                // Rename file
                _logger.LogInformation($"Finished processing job {file.name}");

                string newServerRelativeUrl = "";
                int index = file.serverrelativeurl.LastIndexOf("/");
                if (index > 0)
                {
                    newServerRelativeUrl = file.serverrelativeurl.Substring(0, index) + "/processed_" + file.name;
                }

                try
                {
                    _logger.LogInformation($"Renaming file {file.name} for to processed.");
                    await _sharepoint.RenameFile(file.serverrelativeurl, newServerRelativeUrl);
                }
                catch (SharePointRestException spre)
                {
                    _logger.LogError("Unable to rename file.");
                    _logger.LogError("Message:");
                    _logger.LogError(spre.Message);
                    throw spre;
                }
            }

            return responses;
        }

        private async Task<List<CompletedApplicationScreening>> ProcessApplicationResults(List<FileSystemItem> businessFiles, List<FileSystemItem> associatesFiles)
        {
            List<CompletedApplicationScreening> responses = new List<CompletedApplicationScreening>();
            // Look for files with unprocessed name
            _logger.LogInformation("Looking for unprocessed application files.");
            var unprocessedFiles = businessFiles.Where(f => !f.name.StartsWith("done_")).Where(f => !f.name.StartsWith("processed_")).ToList();
            foreach (var businessFile in unprocessedFiles)
            {
                // Skip if file is not .csv
                if (Path.GetExtension(businessFile.name).ToLower() != ".csv")
                {
                    _logger.LogError($"Business results file found but not of type csv.");
                    continue;
                }

                string jobNumber = businessFile.name.Split("_")[0];

                // Get the matching associates file
                var relevantAssociatesFiles = associatesFiles.Where(f => f.name.StartsWith(jobNumber)).ToList();

                if (relevantAssociatesFiles.Count < 1)
                {
                    _logger.LogError($"Associates file for job id {jobNumber} not found.");
                    continue;
                }
                else if (relevantAssociatesFiles.Count > 1)
                {
                    _logger.LogError($"Too many associates file for job id {jobNumber} found.");
                    continue;
                }

                var associatesFile = relevantAssociatesFiles.First();

                // Download file
                _logger.LogError("Business and associates Files found. Downloading files.");
                byte[] associatesFileContents = await _sharepoint.DownloadFile(associatesFile.serverrelativeurl);
                byte[] businessFileContents = await _sharepoint.DownloadFile(businessFile.serverrelativeurl);

                // Parse file and add to responses list for further processing
                _logger.LogError("Updating application screening response.");
                string businessData = System.Text.Encoding.Default.GetString(businessFileContents);
                string associatesData = System.Text.Encoding.Default.GetString(associatesFileContents);

                responses.Add(ParseApplicationResponse(businessData, associatesData));

                // Rename file
                _logger.LogInformation($"Finished processing job {jobNumber}");

                string businessNewServerRelativeUrl = "";
                int index = businessFile.serverrelativeurl.LastIndexOf("/");
                if (index > 0)
                {
                    businessNewServerRelativeUrl = businessFile.serverrelativeurl.Substring(0, index) + "/done_" + businessFile.name.Substring(0, businessFile.name.Length - 9) + ".csv";
                }

                string associatesNewServerRelativeUrl = "";
                index = associatesFile.serverrelativeurl.LastIndexOf("/");
                if (index > 0)
                {
                    associatesNewServerRelativeUrl = associatesFile.serverrelativeurl.Substring(0, index) + "/done_" + associatesFile.name.Substring(0, associatesFile.name.Length - 9) + ".csv";
                }

                try
                {
                    _logger.LogInformation($"Renaming files for {jobNumber} to processed.");
                    await _sharepoint.RenameFile(businessFile.serverrelativeurl, businessNewServerRelativeUrl);
                    await _sharepoint.RenameFile(associatesFile.serverrelativeurl, associatesNewServerRelativeUrl);
                }
                catch (SharePointRestException spre)
                {
                    _logger.LogError("Unable to rename file.");
                    _logger.LogError("Message:");
                    _logger.LogError(spre.Message);
                    throw spre;
                }
            }
            return responses;
        }

        public CompletedApplicationScreening ParseApplicationResponse(string businessFileContent, string associatesFileContent)
        {
            CsvHelper.Configuration.Configuration config = new CsvHelper.Configuration.Configuration();
            config.SanitizeForInjection = true;
            config.IgnoreBlankLines = true;

            config.TrimOptions = CsvHelper.Configuration.TrimOptions.Trim;
            config.ShouldSkipRecord = record =>
            {
                return record.All(string.IsNullOrEmpty);
            };

            // fix for unexpected spaces in header
            config.PrepareHeaderForMatch = (string header, int index) => header = header.Trim().ToLower();

            TextReader businessTextReader = new StringReader(businessFileContent);
            var businessCsv = new CsvReader(businessTextReader, config);
            businessCsv.Configuration.RegisterClassMap<CsvBusinessImportMap>();

            TextReader associatesTextReader = new StringReader(associatesFileContent);
            var associatesCsv = new CsvReader(associatesTextReader, config);
            associatesCsv.Configuration.RegisterClassMap<CsvAssociateImportMap>();

            try
            {
                CsvBusinessImport businessImport = businessCsv.GetRecords<CsvBusinessImport>().ToList().First();
                List<CsvAssociateImport> associatesImport = associatesCsv.GetRecords<CsvAssociateImport>().ToList();


                CompletedApplicationScreening response = new CompletedApplicationScreening()
                {
                    RecordIdentifier = businessImport.LcrbBusinessJobId.PadLeft(6, '0'),
                    Result = CsvBusinessImport.TranslateStatus(businessImport.Result),
                    Associates = new List<Associate>()
                };
                foreach(var associate in associatesImport)
                {
                    response.Associates.Add(new Associate()
                    {
                        SpdJobId = associate.LcrbAssociateJobId,
                        LastName = associate.Last,
                        FirstName = associate.First,
                        MiddleName = associate.Middle
                    });
                }
                return response;
            }
            catch (Exception e)
            {
                _logger.LogError("Error parsing worker response.");
                _logger.LogError("Message:");
                _logger.LogError(e.Message);
                // return an empty list so we continue processing other files.
                return new CompletedApplicationScreening();
            }
        }

        public List<CompletedWorkerScreening> ParseWorkerResponse(string fileContent)
        {
            CsvHelper.Configuration.Configuration config = new CsvHelper.Configuration.Configuration();
            config.SanitizeForInjection = true;
            config.IgnoreBlankLines = true;

            config.TrimOptions = CsvHelper.Configuration.TrimOptions.Trim;
            config.ShouldSkipRecord = record =>
            {
                return record.All(string.IsNullOrEmpty);
            };

            // fix for unexpected spaces in header
            config.PrepareHeaderForMatch = (string header, int index) => header = header.Trim().ToLower();

            TextReader textReader = new StringReader(fileContent);
            var workerCsv = new CsvReader(textReader, config);
            workerCsv.Configuration.RegisterClassMap<CsvWorkerImportMap>();

            try
            {
                List<CsvWorkerImport> imports = workerCsv.GetRecords<CsvWorkerImport>().ToList();
                List<CompletedWorkerScreening> responses = new List<CompletedWorkerScreening>();
                foreach (var import in imports)
                {
                    if (import.RecordIdentifier.Substring(0, 2) == "WR")
                    {
                        responses.Add(new CompletedWorkerScreening()
                        {
                            RecordIdentifier = import.RecordIdentifier,
                            ScreeningResult = CsvWorkerImport.TranslateStatus(import.Result)
                        });
                    }
                    else
                    {
                        responses.Add(new CompletedWorkerScreening()
                        {
                            SpdJobId = import.RecordIdentifier,
                            ScreeningResult = CsvWorkerImport.TranslateStatus(import.Result)
                        });
                    }
                    
                }

                return responses;
            }
            catch (Exception e)
            {
                _logger.LogError("Error parsing worker response.");
                _logger.LogError("Message:");
                _logger.LogError(e.Message);
                // return an empty list so we continue processing other files.
                return new List<CompletedWorkerScreening>();
            }
        }

        public async Task<List<FileSystemItem>> getFileDetailsListInFolder(string libraryPath, string folderPath)
        {
            List<FileSystemItem> fileSystemItemVMList = new List<FileSystemItem>();

            // Get the file details list in folder
            List<FileDetailsList> fileDetailsList = null;
            try
            {
                fileDetailsList = await _sharepoint.GetFileDetailsListInFolder(libraryPath, folderPath, "");
            }
            catch (SharePointRestException spre)
            {
                _logger.LogError("Unable to get Sharepoint File List.");
                _logger.LogError("Request:");
                _logger.LogError(spre.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(spre.Request.Content);
                throw spre;
            }

            if (fileDetailsList != null)
            {
                foreach (FileDetailsList fileDetails in fileDetailsList)
                {
                    FileSystemItem fileSystemItemVM = new FileSystemItem()
                    {
                        // remove the document type text from file name
                        name = fileDetails.Name,
                        // convert size from bytes (original) to KB
                        size = int.Parse(fileDetails.Length),
                        serverrelativeurl = fileDetails.ServerRelativeUrl,
                        timelastmodified = DateTime.Parse(fileDetails.TimeLastModified),
                        documenttype = fileDetails.DocumentType
                    };

                    fileSystemItemVMList.Add(fileSystemItemVM);
                }
            }

            return fileSystemItemVMList;
        }
    }
}
