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
    /// BooleanManagedProperty
    /// </summary>
    public partial class MicrosoftDynamicsCRMBooleanManagedProperty
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanManagedProperty class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanManagedProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBooleanManagedProperty class.
        /// </summary>
        public MicrosoftDynamicsCRMBooleanManagedProperty(bool? value = default(bool?), bool? canBeChanged = default(bool?), string managedPropertyLogicalName = default(string))
        {
            Value = value;
            CanBeChanged = canBeChanged;
            ManagedPropertyLogicalName = managedPropertyLogicalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public bool? Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeChanged")]
        public bool? CanBeChanged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManagedPropertyLogicalName")]
        public string ManagedPropertyLogicalName { get; set; }

    }
}
