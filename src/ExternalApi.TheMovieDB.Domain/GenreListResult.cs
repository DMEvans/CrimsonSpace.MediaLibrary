//-----------------------------------------------------------------------
// <copyright file="GenreListResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Genre list container class
    /// </summary>
    public class GenreListResult
    {
        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        [JsonProperty(PropertyName = "genres")]
        public List<GenreResult> Genres { get; set; }
    }
}