//-----------------------------------------------------------------------
// <copyright file="BasicMovieResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using System.Collections.Generic;

    /// <summary>
    /// Model class for a basic movie result
    /// </summary>
    public class BasicMovieResultModel
    {
        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public List<NamedItemModel> Genres { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the poster image URL.
        /// </summary>
        /// <value>
        /// The poster image URL.
        /// </value>
        public string PosterImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the release year.
        /// </summary>
        /// <value>
        /// The release year.
        /// </value>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
    }
}