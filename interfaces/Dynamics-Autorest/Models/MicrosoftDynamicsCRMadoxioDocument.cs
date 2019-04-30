// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_document
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioDocument
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioDocument class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioDocument()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioDocument class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioDocument(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _modifiedbyValue = default(string), string _owneridValue = default(string), string _adoxioInvestigationidValue = default(string), int? importsequencenumber = default(int?), int? statecode = default(int?), string _owningteamValue = default(string), string _createdonbehalfbyValue = default(string), string _adoxioBusinessprofileidValue = default(string), string _owninguserValue = default(string), int? timezoneruleversionnumber = default(int?), string _adoxioApplicationidValue = default(string), int? adoxioDocumenttype = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string _adoxioWorkerverificationidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _adoxioDocumentlinkidValue = default(string), string adoxioDocumentid = default(string), string _adoxioInspectionidValue = default(string), string _modifiedonbehalfbyValue = default(string), string adoxioName = default(string), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), string _createdbyValue = default(string), string _adoxioIndividualidValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioDocumentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioDocumentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioDocumentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioDocumentSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioDocumentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioDocumentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioApplication adoxioApplicationId = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMincident adoxioInspectionId = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMadoxioInvestigation adoxioInvestigationId = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMaccount adoxioBusinessProfileId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact adoxioIndividualId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioDocumentadmin adoxioDocumentLinkId = default(MicrosoftDynamicsCRMadoxioDocumentadmin), MicrosoftDynamicsCRMadoxioWorker adoxioWorkerVerificationId = default(MicrosoftDynamicsCRMadoxioWorker))
        {
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            this._adoxioInvestigationidValue = _adoxioInvestigationidValue;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._adoxioBusinessprofileidValue = _adoxioBusinessprofileidValue;
            this._owninguserValue = _owninguserValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._adoxioApplicationidValue = _adoxioApplicationidValue;
            AdoxioDocumenttype = adoxioDocumenttype;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._adoxioWorkerverificationidValue = _adoxioWorkerverificationidValue;
            Modifiedon = modifiedon;
            this._adoxioDocumentlinkidValue = _adoxioDocumentlinkidValue;
            AdoxioDocumentid = adoxioDocumentid;
            this._adoxioInspectionidValue = _adoxioInspectionidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioName = adoxioName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            this._adoxioIndividualidValue = _adoxioIndividualidValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioDocumentSyncErrors = adoxioDocumentSyncErrors;
            AdoxioDocumentDuplicateMatchingRecord = adoxioDocumentDuplicateMatchingRecord;
            AdoxioDocumentDuplicateBaseRecord = adoxioDocumentDuplicateBaseRecord;
            AdoxioDocumentSharePointDocumentLocations = adoxioDocumentSharePointDocumentLocations;
            AdoxioDocumentAsyncOperations = adoxioDocumentAsyncOperations;
            AdoxioDocumentBulkDeleteFailures = adoxioDocumentBulkDeleteFailures;
            AdoxioApplicationId = adoxioApplicationId;
            AdoxioInspectionId = adoxioInspectionId;
            AdoxioInvestigationId = adoxioInvestigationId;
            AdoxioBusinessProfileId = adoxioBusinessProfileId;
            AdoxioIndividualId = adoxioIndividualId;
            AdoxioDocumentLinkId = adoxioDocumentLinkId;
            AdoxioWorkerVerificationId = adoxioWorkerVerificationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigationid_value")]
        public string _adoxioInvestigationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_businessprofileid_value")]
        public string _adoxioBusinessprofileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationid_value")]
        public string _adoxioApplicationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_documenttype")]
        public int? AdoxioDocumenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_workerverificationid_value")]
        public string _adoxioWorkerverificationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_documentlinkid_value")]
        public string _adoxioDocumentlinkidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_documentid")]
        public string AdoxioDocumentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspectionid_value")]
        public string _adoxioInspectionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_individualid_value")]
        public string _adoxioIndividualidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_document_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioDocumentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_document_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioDocumentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_document_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioDocumentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_document_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioDocumentSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_document_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioDocumentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_document_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioDocumentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationId")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplicationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InspectionId")]
        public MicrosoftDynamicsCRMincident AdoxioInspectionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InvestigationId")]
        public MicrosoftDynamicsCRMadoxioInvestigation AdoxioInvestigationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_BusinessProfileId")]
        public MicrosoftDynamicsCRMaccount AdoxioBusinessProfileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_IndividualId")]
        public MicrosoftDynamicsCRMcontact AdoxioIndividualId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_DocumentLinkId")]
        public MicrosoftDynamicsCRMadoxioDocumentadmin AdoxioDocumentLinkId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_WorkerVerificationId")]
        public MicrosoftDynamicsCRMadoxioWorker AdoxioWorkerVerificationId { get; set; }

    }
}
