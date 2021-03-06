﻿using Gov.Jag.Spice.Public.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Extensions.Logging;

namespace Gov.Jag.Spice.Public.Controllers
{
    [Route("api/[controller]")]
    public class ApplicationVersionInfoController : ControllerBase
    {
        private readonly ILogger<ApplicationVersionInfoController> _logger;
        private readonly IConfiguration Configuration;

        public ApplicationVersionInfoController(ILogger<ApplicationVersionInfoController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;                  
        }

        /// <summary>
        /// Return the version of the running application
        /// </summary>
        /// <returns>The version of the running application</returns>
        [HttpGet]        
        public ActionResult GetApplicationVersionInfo()
        {
            var assembly = GetType().GetTypeInfo().Assembly;
            var creationTime = System.IO.File.GetLastWriteTimeUtc(assembly.Location);
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string fileVersion = fvi.FileVersion;
            
            var avi = new ApplicationVersionInfo
            {
                BaseUri = Configuration["BASE_URI"],
                BasePath = Configuration["BASE_PATH"],
                Environment = Configuration["ASPNETCORE_ENVIRONMENT"],                
                SourceCommit = Configuration["OPENSHIFT_BUILD_COMMIT"],
                SourceRepository = Configuration["OPENSHIFT_BUILD_SOURCE"],
                SourceReference = Configuration["OPENSHIFT_BUILD_REFERENCE"],
                FileCreationTime = creationTime.ToString("O"), // Use the round trip format as it includes the time zone.
                FileVersion = fileVersion
            };

            _logger.LogInformation("Displaying application version information: {@VersionInformation}", avi);

            return new JsonResult(avi);
        }
	}
}
