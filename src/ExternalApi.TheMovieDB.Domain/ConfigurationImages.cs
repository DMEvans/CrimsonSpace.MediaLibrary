//-----------------------------------------------------------------------
// <copyright file="ConfigurationImages.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Image configuration details container class
    /// </summary>
    public class ConfigurationImages
    {
        /// <summary>
        /// Gets or sets the backdrop sizes.
        /// </summary>
        /// <value>
        /// The backdrop sizes.
        /// </value>
        [JsonProperty(PropertyName = "backdrop_sizes")]
        public List<string> BackdropSizes { get; set; }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        [JsonProperty(PropertyName = "base_url")]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the logo sizes.
        /// </summary>
        /// <value>
        /// The logo sizes.
        /// </value>
        [JsonProperty(PropertyName = "logo_sizes")]
        public List<string> LogoSizes { get; set; }

        /// <summary>
        /// Gets or sets the poster sizes.
        /// </summary>
        /// <value>
        /// The poster sizes.
        /// </value>
        [JsonProperty(PropertyName = "poster_sizes")]
        public List<string> PosterSizes { get; set; }

        /// <summary>
        /// Gets or sets the profile sizes.
        /// </summary>
        /// <value>
        /// The profile sizes.
        /// </value>
        [JsonProperty(PropertyName = "profile_sizes")]
        public List<string> ProfileSizes { get; set; }

        /// <summary>
        /// Gets or sets the secure base URL.
        /// </summary>
        /// <value>
        /// The secure base URL.
        /// </value>
        [JsonProperty(PropertyName = "secure_base_url")]
        public string SecureBaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the still sizes.
        /// </summary>
        /// <value>
        /// The still sizes.
        /// </value>
        [JsonProperty(PropertyName = "still_sizes")]
        public List<string> StillSizes { get; set; }
    }
}