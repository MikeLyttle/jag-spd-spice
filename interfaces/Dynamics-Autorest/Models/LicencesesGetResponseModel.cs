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
    /// Collection of adoxio_licenceses
    /// </summary>
    public partial class LicencesesGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the LicencesesGetResponseModel class.
        /// </summary>
        public LicencesesGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicencesesGetResponseModel class.
        /// </summary>
        public LicencesesGetResponseModel(IList<MicrosoftDynamicsCRMadoxioLicences> value = default(IList<MicrosoftDynamicsCRMadoxioLicences>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> Value { get; set; }

    }
}
