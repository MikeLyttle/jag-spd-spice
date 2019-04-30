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
    /// SecurityPrivilegeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMSecurityPrivilegeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMSecurityPrivilegeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMSecurityPrivilegeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMSecurityPrivilegeMetadata class.
        /// </summary>
        /// <param name="privilegeType">Possible values include: 'None',
        /// 'Create', 'Read', 'Write', 'Delete', 'Assign', 'Share', 'Append',
        /// 'AppendTo'</param>
        public MicrosoftDynamicsCRMSecurityPrivilegeMetadata(bool? canBeBasic = default(bool?), bool? canBeDeep = default(bool?), bool? canBeGlobal = default(bool?), bool? canBeLocal = default(bool?), bool? canBeEntityReference = default(bool?), bool? canBeParentEntityReference = default(bool?), string name = default(string), string privilegeId = default(string), string privilegeType = default(string))
        {
            CanBeBasic = canBeBasic;
            CanBeDeep = canBeDeep;
            CanBeGlobal = canBeGlobal;
            CanBeLocal = canBeLocal;
            CanBeEntityReference = canBeEntityReference;
            CanBeParentEntityReference = canBeParentEntityReference;
            Name = name;
            PrivilegeId = privilegeId;
            PrivilegeType = privilegeType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeBasic")]
        public bool? CanBeBasic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeDeep")]
        public bool? CanBeDeep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeGlobal")]
        public bool? CanBeGlobal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeLocal")]
        public bool? CanBeLocal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeEntityReference")]
        public bool? CanBeEntityReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeParentEntityReference")]
        public bool? CanBeParentEntityReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrivilegeId")]
        public string PrivilegeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Create', 'Read',
        /// 'Write', 'Delete', 'Assign', 'Share', 'Append', 'AppendTo'
        /// </summary>
        [JsonProperty(PropertyName = "PrivilegeType")]
        public string PrivilegeType { get; set; }

    }
}
