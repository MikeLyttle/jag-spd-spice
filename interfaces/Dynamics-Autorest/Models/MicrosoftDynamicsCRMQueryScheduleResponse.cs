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
    /// QueryScheduleResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMQueryScheduleResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryScheduleResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryScheduleResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryScheduleResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryScheduleResponse(IList<MicrosoftDynamicsCRMTimeInfo> timeInfos = default(IList<MicrosoftDynamicsCRMTimeInfo>))
        {
            TimeInfos = timeInfos;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeInfos")]
        public IList<MicrosoftDynamicsCRMTimeInfo> TimeInfos { get; set; }

    }
}
