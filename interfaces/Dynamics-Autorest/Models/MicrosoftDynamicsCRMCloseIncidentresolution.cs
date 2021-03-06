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
    /// incidentresolution
    /// </summary>
    public partial class MicrosoftDynamicsCRMCloseIncidentresolution
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCloseIncidentresolution class.
        /// </summary>
        public MicrosoftDynamicsCRMCloseIncidentresolution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCloseIncidentresolution class.
        /// </summary>
        public MicrosoftDynamicsCRMCloseIncidentresolution(int? statuscode = default(int?), int? statecode = default(int?), string incidentidodatabind = default(string), string subject = default(string))
        {
            Statuscode = statuscode;
            Statecode = statecode;
            Incidentidodatabind = incidentidodatabind;
            Subject = subject;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid@odata.bind")]
        public string Incidentidodatabind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

    }
}
