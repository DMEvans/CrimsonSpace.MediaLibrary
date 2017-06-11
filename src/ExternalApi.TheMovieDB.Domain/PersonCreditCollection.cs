//-----------------------------------------------------------------------
// <copyright file="PersonCreditCollection.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Container class for a person's credits
    /// </summary>
    public class PersonCreditCollection
    {
        /// <summary>
        /// Gets or sets the cast.
        /// </summary>
        /// <value>
        /// The cast.
        /// </value>
        [JsonProperty("cast")]
        public IList<CastCreditResult> Cast { get; set; }

        /// <summary>
        /// Gets or sets the crew.
        /// </summary>
        /// <value>
        /// The crew.
        /// </value>
        [JsonProperty("crew")]
        public IList<CrewCreditResult> Crew { get; set; }
    }
}