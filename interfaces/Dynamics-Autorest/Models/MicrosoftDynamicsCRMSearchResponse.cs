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
    /// SearchResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMSearchResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMSearchResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMSearchResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMSearchResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMSearchResponse(MicrosoftDynamicsCRMSearchResults searchResults = default(MicrosoftDynamicsCRMSearchResults))
        {
            SearchResults = searchResults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SearchResults")]
        public MicrosoftDynamicsCRMSearchResults SearchResults { get; set; }

    }
}
