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
    /// Collection of teams
    /// </summary>
    public partial class TeamsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the TeamsGetResponseModel class.
        /// </summary>
        public TeamsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamsGetResponseModel class.
        /// </summary>
        public TeamsGetResponseModel(IList<MicrosoftDynamicsCRMteam> value = default(IList<MicrosoftDynamicsCRMteam>))
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
        public IList<MicrosoftDynamicsCRMteam> Value { get; set; }

    }
}
