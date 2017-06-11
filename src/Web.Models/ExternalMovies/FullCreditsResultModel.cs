//-----------------------------------------------------------------------
// <copyright file="FullCreditsResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using System.Collections.Generic;

    /// <summary>
    /// Full credits model
    /// </summary>
    public class FullCreditsResultModel
    {
        #region Properties

        /// <summary>
        /// Gets the backdrop image URL.
        /// </summary>
        /// <value>
        /// The backdrop image URL.
        /// </value>
        public string BackdropImageCss => HasBackdrop ? string.Format("background-image: url(\"{0}\"); background-position: center;", BackdropImageUrl) : string.Empty;

        /// <summary>
        /// Gets or sets the backdrop image URL.
        /// </summary>
        /// <value>
        /// The backdrop image URL.
        /// </value>
        public string BackdropImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the cast.
        /// </summary>
        /// <value>
        /// The cast.
        /// </value>
        public IEnumerable<CastResultModel> Cast { get; set; }

        /// <summary>
        /// Gets or sets the crew.
        /// </summary>
        /// <value>
        /// The crew.
        /// </value>
        public IEnumerable<CrewGroupResultModel> Crew { get; set; }

        /// <summary>
        /// Gets or sets the departments.
        /// </summary>
        /// <value>
        /// The departments.
        /// </value>
        public IEnumerable<string> Departments { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public IEnumerable<NamedItemModel> Genres { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has as backdrop image.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has a backdrop image; otherwise, <c>false</c>.
        /// </value>
        public bool HasBackdrop => !string.IsNullOrWhiteSpace(BackdropImageUrl);

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
        /// Gets or sets the poster path for the original size image.
        /// </summary>
        /// <value>
        /// The poster path for the original size image.
        /// </value>
        public string PosterImageUrlOriginal { get; set; }

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

        #endregion Properties
    }
}