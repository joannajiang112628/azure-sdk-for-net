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
    /// RequestsBasedTrigger
    /// </summary>
    public partial class RequestsBasedTrigger
    {
        /// <summary>
        /// Initializes a new instance of the RequestsBasedTrigger class.
        /// </summary>
        public RequestsBasedTrigger() { }

        /// <summary>
        /// Initializes a new instance of the RequestsBasedTrigger class.
        /// </summary>
        public RequestsBasedTrigger(int? count = default(int?), string timeInterval = default(string))
        {
            Count = count;
            TimeInterval = timeInterval;
        }

        /// <summary>
        /// Count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// TimeInterval
        /// </summary>
        [JsonProperty(PropertyName = "timeInterval")]
        public string TimeInterval { get; set; }

    }
}
