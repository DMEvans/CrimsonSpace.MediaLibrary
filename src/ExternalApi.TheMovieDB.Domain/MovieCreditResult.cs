//-----------------------------------------------------------------------
// <copyright file="MovieCreditResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Movie credit result container class
    /// </summary>
    public class MovieCreditResult
    {
        /// <summary>
        /// Gets or sets the movie identifier.
        /// </summary>
        /// <value>
        /// The movie identifier.
        /// </value>
        [JsonProperty("id")]
        public int MovieId { get; set; }

        /// <summary>
        /// Gets or sets the list of cast members.
        /// </summary>
        /// <value>
        /// The list of cast members.
        /// </value>
        [JsonProperty("cast")]
        public List<CastResult> Cast { get; set; }

        /// <summary>
        /// Gets or sets the list of crew members.
        /// </summary>
        /// <value>
        /// The list of crew members.
        /// </value>
        [JsonProperty("crew")]
        public List<CrewResult> Crew { get; set; }
    }
}
