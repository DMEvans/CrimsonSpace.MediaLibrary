//-----------------------------------------------------------------------
// <copyright file="PersonImageCollection.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Container class for person image results
    /// </summary>
    public class PersonImageCollection
    {
        /// <summary>
        /// Gets or sets the profile images.
        /// </summary>
        /// <value>
        /// The profile images.
        /// </value>
        [JsonProperty("profiles")]
        public IList<ImageResult> Profiles { get; set; }
    }
}