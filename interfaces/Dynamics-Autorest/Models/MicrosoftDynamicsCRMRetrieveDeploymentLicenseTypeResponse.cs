// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RetrieveDeploymentLicenseTypeResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveDeploymentLicenseTypeResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveDeploymentLicenseTypeResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveDeploymentLicenseTypeResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveDeploymentLicenseTypeResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveDeploymentLicenseTypeResponse(string licenseType = default(string))
        {
            LicenseType = licenseType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

    }
}
