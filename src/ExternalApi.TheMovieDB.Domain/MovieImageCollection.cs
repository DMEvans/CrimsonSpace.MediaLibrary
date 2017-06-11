//-----------------------------------------------------------------------
// <copyright file="MovieImageCollection.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Container class for movie images
    /// </summary>
    public class MovieImageCollection
    {
        /// <summary>
        /// Gets or sets the backdrop images.
        /// </summary>
        /// <value>
        /// The backdrop images.
        /// </value>
        [JsonProperty("backdrops")]
        public IList<ImageResult> Backdrops { get; set; }

        /// <summary>
        /// Gets or sets the poster images.
        /// </summary>
        /// <value>
        /// The poster images.
        /// </value>
        [JsonProperty("posters")]
        public IList<ImageResult> Posters { get; set; }
    }
}