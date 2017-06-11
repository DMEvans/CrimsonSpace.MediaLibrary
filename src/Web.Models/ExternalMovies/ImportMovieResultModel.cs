//-----------------------------------------------------------------------
// <copyright file="ImportMovieResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Model class for an import movie result
    /// </summary>
    public class ImportMovieResultModel
    {
        /// <summary>
        /// Gets or sets the backdrop image URL.
        /// </summary>
        /// <value>
        /// The backdrop image URL.
        /// </value>
        public string BackdropImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the budget.
        /// </summary>
        /// <value>
        /// The budget.
        /// </value>
        public double Budget { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public List<NamedItemModel> Genres { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has as backdrop image.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has a backdrop image; otherwise, <c>false</c>.
        /// </value>
        public bool HasBackdrop => !string.IsNullOrWhiteSpace(BackdropImageUrl);

        /// <summary>
        /// Gets a value indicating whether this instance has poster.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has poster; otherwise, <c>false</c>.
        /// </value>
        public bool HasPoster => !string.IsNullOrWhiteSpace(PosterImageUrl);

        /// <summary>
        /// Gets or sets the home page.
        /// </summary>
        /// <value>
        /// The home page.
        /// </value>
        public string HomePage { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the IMDB identifier.
        /// </summary>
        /// <value>
        /// The IMDB identifier.
        /// </value>
        public string ImdbId { get; set; }

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
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the revenue.
        /// </summary>
        /// <value>
        /// The revenue.
        /// </value>
        public double Revenue { get; set; }

        /// <summary>
        /// Gets or sets the runtime in minutes.
        /// </summary>
        /// <value>
        /// The runtime in minutes.
        /// </value>
        public int Runtime { get; set; }

        /// <summary>
        /// Gets or sets the tagline.
        /// </summary>
        /// <value>
        /// The tagline.
        /// </value>
        public string Tagline { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
    }
}