// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ApplicationScreeningResponse
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationScreeningResponse
        /// class.
        /// </summary>
        public ApplicationScreeningResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationScreeningResponse
        /// class.
        /// </summary>
        public ApplicationScreeningResponse(string recordIdentifier = default(string), string result = default(string), IList<Associate> associates = default(IList<Associate>))
        {
            RecordIdentifier = recordIdentifier;
            Result = result;
            Associates = associates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordIdentifier")]
        public string RecordIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associates")]
        public IList<Associate> Associates { get; set; }

    }
}
