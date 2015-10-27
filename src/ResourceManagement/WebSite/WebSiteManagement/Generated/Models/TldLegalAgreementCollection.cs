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
    /// Collection of Tld Legal Agreements
    /// </summary>
    public partial class TldLegalAgreementCollection
    {
        /// <summary>
        /// Initializes a new instance of the TldLegalAgreementCollection
        /// class.
        /// </summary>
        public TldLegalAgreementCollection() { }

        /// <summary>
        /// Initializes a new instance of the TldLegalAgreementCollection
        /// class.
        /// </summary>
        public TldLegalAgreementCollection(IList<TldLegalAgreement> value = default(IList<TldLegalAgreement>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<TldLegalAgreement> Value { get; set; }

        /// <summary>
        /// Link to next page of resources
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
