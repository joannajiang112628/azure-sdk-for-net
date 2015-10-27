// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Collection of geo regions
    /// </summary>
    public partial class GeoRegionCollection
    {
        /// <summary>
        /// Initializes a new instance of the GeoRegionCollection class.
        /// </summary>
        public GeoRegionCollection() { }

        /// <summary>
        /// Initializes a new instance of the GeoRegionCollection class.
        /// </summary>
        public GeoRegionCollection(IList<GeoRegion> value = default(IList<GeoRegion>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GeoRegion> Value { get; set; }

        /// <summary>
        /// Link to next page of resources
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
