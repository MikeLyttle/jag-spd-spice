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
    /// RetrieveEntityRibbonResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveEntityRibbonResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveEntityRibbonResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveEntityRibbonResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveEntityRibbonResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveEntityRibbonResponse(object compressedEntityXml = default(object))
        {
            CompressedEntityXml = compressedEntityXml;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompressedEntityXml")]
        public object CompressedEntityXml { get; set; }

    }
}
