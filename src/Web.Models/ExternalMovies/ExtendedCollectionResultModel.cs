//-----------------------------------------------------------------------
// <copyright file="ExtendedCollectionResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using ExternalApi.TheMovieDB.Domain;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection model
    /// </summary>
    public class ExtendedCollectionResultModel
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
        /// Gets a value indicating whether this collection has parts.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this collection has parts; otherwise, <c>false</c>.
        /// </value>
        public bool HasParts => Parts.Any();

        /// <summary>
        /// Gets the number of instalments.
        /// </summary>
        /// <value>
        /// The number of instalments.
        /// </value>
        public int NumberOfParts => HasParts ? Parts.Count() : 0;

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the parts.
        /// </summary>
        /// <value>
        /// The parts.
        /// </value>
        public IEnumerable<BasicMovieResultModel> Parts { get; set; }

        /// <summary>
        /// Gets or sets the poster image URL.
        /// </summary>
        /// <value>
        /// The poster image URL.
        /// </value>
        public string PosterImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the poster image URL at it's original size.
        /// </summary>
        /// <value>
        /// The poster image URL at it's original size.
        /// </value>
        public string PosterImageUrlOriginal { get; set; }

        /// <summary>
        /// Gets or sets the name of the collection.
        /// </summary>
        /// <value>
        /// The name of the collection.
        /// </value>
        public string Name { get; set; }

        #endregion Properties
    }
}