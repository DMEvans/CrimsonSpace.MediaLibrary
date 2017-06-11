//-----------------------------------------------------------------------
// <copyright file="RegionResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;

    /// <summary>
    /// Region result container class
    /// </summary>
    public class RegionResult
    {
        /// <summary>
        /// Gets or sets the ISO 3166 region code.
        /// </summary>
        /// <value>
        /// The ISO 3166 region code.
        /// </value>
        [JsonProperty(PropertyName = "iso_3166_1")]
        public string Iso3166_Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}