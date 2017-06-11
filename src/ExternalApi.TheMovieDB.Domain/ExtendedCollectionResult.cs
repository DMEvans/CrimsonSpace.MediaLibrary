//-----------------------------------------------------------------------
// <copyright file="ExtendedCollectionResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Interfaces;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Container class for a movie collection result
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.BasicCollectionResult" />
    public class ExtendedCollectionResult : BasicCollectionResult
    {
        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [JsonProperty("overview")]
        public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the parts.
        /// </summary>
        /// <value>
        /// The parts.
        /// </value>
        [JsonProperty("parts")]
        public List<BasicMovieResult> Parts { get; set; }
    }
}