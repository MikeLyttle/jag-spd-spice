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
    /// accountleads
    /// </summary>
    public partial class MicrosoftDynamicsCRMaccountleads
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMaccountleads
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMaccountleads()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMaccountleads
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMaccountleads(string accountleadid = default(string), string leadid = default(string), string accountid = default(string), long? versionnumber = default(long?))
        {
            Accountleadid = accountleadid;
            Leadid = leadid;
            Accountid = accountid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountleadid")]
        public string Accountleadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadid")]
        public string Leadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountid")]
        public string Accountid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
