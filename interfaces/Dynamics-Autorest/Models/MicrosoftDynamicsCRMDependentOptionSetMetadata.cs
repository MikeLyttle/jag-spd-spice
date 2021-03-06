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
    /// DependentOptionSetMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMDependentOptionSetMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentOptionSetMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentOptionSetMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentOptionSetMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentOptionSetMetadata(string name = default(string), string type = default(string), MicrosoftDynamicsCRMDependentOptionMetadata trueOption = default(MicrosoftDynamicsCRMDependentOptionMetadata), MicrosoftDynamicsCRMDependentOptionMetadata falseOption = default(MicrosoftDynamicsCRMDependentOptionMetadata), MicrosoftDynamicsCRMDependentOptionMetadataCollection options = default(MicrosoftDynamicsCRMDependentOptionMetadataCollection))
        {
            Name = name;
            Type = type;
            TrueOption = trueOption;
            FalseOption = falseOption;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrueOption")]
        public MicrosoftDynamicsCRMDependentOptionMetadata TrueOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FalseOption")]
        public MicrosoftDynamicsCRMDependentOptionMetadata FalseOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Options")]
        public MicrosoftDynamicsCRMDependentOptionMetadataCollection Options { get; set; }

    }
}
