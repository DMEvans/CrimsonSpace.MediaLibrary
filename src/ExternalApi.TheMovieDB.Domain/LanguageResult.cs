//-----------------------------------------------------------------------
// <copyright file="LanguageResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;

    /// <summary>
    /// Language result container class
    /// </summary>
    public class LanguageResult
    {
        /// <summary>
        /// Gets or sets the ISO 639 language code.
        /// </summary>
        /// <value>
        /// The ISO 639 language code.
        /// </value>
        [JsonProperty(PropertyName = "iso_639_1")]
        public string Iso639_Code { get; set; }

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