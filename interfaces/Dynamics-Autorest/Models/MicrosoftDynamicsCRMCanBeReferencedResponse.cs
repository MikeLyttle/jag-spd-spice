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
    /// CanBeReferencedResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCanBeReferencedResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCanBeReferencedResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCanBeReferencedResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCanBeReferencedResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCanBeReferencedResponse(bool? canBeReferenced = default(bool?))
        {
            CanBeReferenced = canBeReferenced;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeReferenced")]
        public bool? CanBeReferenced { get; set; }

    }
}
