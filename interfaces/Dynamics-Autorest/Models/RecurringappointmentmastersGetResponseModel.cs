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
    /// Collection of recurringappointmentmasters
    /// </summary>
    public partial class RecurringappointmentmastersGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecurringappointmentmastersGetResponseModel class.
        /// </summary>
        public RecurringappointmentmastersGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecurringappointmentmastersGetResponseModel class.
        /// </summary>
        public RecurringappointmentmastersGetResponseModel(IList<MicrosoftDynamicsCRMrecurringappointmentmaster> value = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>))
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
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> Value { get; set; }

    }
}
