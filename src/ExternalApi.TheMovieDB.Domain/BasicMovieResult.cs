//-----------------------------------------------------------------------
// <copyright file="BasicMovieResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Base;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Basic movie result container class
    /// </summary>
    public class BasicMovieResult : BaseMovieResult
    {
        /// <summary>
        /// Gets or sets the genre ids.
        /// </summary>
        /// <value>
        /// The genre ids.
        /// </value>
        [JsonProperty(PropertyName = "genre_ids")]
        public List<int> GenreIds { get; set; }
    }
}