//-----------------------------------------------------------------------
// <copyright file="ConfigurationDetails.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// API configuration container class
    /// </summary>
    public class ConfigurationDetails
    {
        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        [JsonIgnore]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the change keys.
        /// </summary>
        /// <value>
        /// The change keys.
        /// </value>
        [JsonProperty(PropertyName = "change_keys")]
        public List<string> ChangeKeys { get; set; }

        /// <summary>
        /// Gets or sets the image configuration details.
        /// </summary>
        /// <value>
        /// The image configuration details.
        /// </value>
        [JsonProperty(PropertyName = "images")]
        public ConfigurationImages Images { get; set; }
    }
}