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
    /// adoxio_licencetypes_applicationtypes
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes(long? versionnumber = default(long?), string adoxioLicencetypesApplicationtypesid = default(string), string adoxioApplicationtypeid = default(string), string adoxioLicencetypeid = default(string))
        {
            Versionnumber = versionnumber;
            AdoxioLicencetypesApplicationtypesid = adoxioLicencetypesApplicationtypesid;
            AdoxioApplicationtypeid = adoxioApplicationtypeid;
            AdoxioLicencetypeid = adoxioLicencetypeid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypes_applicationtypesid")]
        public string AdoxioLicencetypesApplicationtypesid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtypeid")]
        public string AdoxioApplicationtypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypeid")]
        public string AdoxioLicencetypeid { get; set; }

    }
}
