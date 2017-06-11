//-----------------------------------------------------------------------
// <copyright file="MovieSearchResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Movie search result container class
    /// </summary>
    public class MovieSearchResult
    {
        /// <summary>
        /// Gets or sets the current page number from the results.
        /// </summary>
        /// <value>
        /// The current page number from the results.
        /// </value>
        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        [JsonProperty(PropertyName = "results")]
        public List<BasicMovieResult> Results { get; set; } = new List<BasicMovieResult>();

        /// <summary>
        /// Gets or sets the total pages.
        /// </summary>
        /// <value>
        /// The total pages.
        /// </value>
        [JsonProperty(PropertyName = "total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the total results.
        /// </summary>
        /// <value>
        /// The total results.
        /// </value>
        [JsonProperty(PropertyName = "total_results")]
        public int TotalResults { get; set; }
    }
}