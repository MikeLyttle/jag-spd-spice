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
    /// AddToQueueResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMAddToQueueResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAddToQueueResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMAddToQueueResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAddToQueueResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMAddToQueueResponse(string queueItemId = default(string))
        {
            QueueItemId = queueItemId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItemId")]
        public string QueueItemId { get; set; }

    }
}
