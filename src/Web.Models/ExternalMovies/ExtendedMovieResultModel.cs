//-----------------------------------------------------------------------
// <copyright file="ExtendedMovieResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using System.Collections.Generic;

    /// <summary>
    /// Model class for an extended movie result
    /// </summary>
    public class ExtendedMovieResultModel
    {
        /// <summary>
        /// Gets or sets the backdrop image CSS.
        /// </summary>
        /// <value>
        /// The backdrop image CSS.
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
        /// Gets a value indicating whether the movie belongs to a collection.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the movie belongs to a collection; otherwise, <c>false</c>.
        /// </value>
        public bool BelongsToCollection => Collection != null;

        /// <summary>
        /// Gets or sets the budget.
        /// </summary>
        /// <value>
        /// The budget.
        /// </value>
        public string Budget { get; set; }

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        /// <value>
        /// The collection.
        /// </value>
        public object Collection { get; set; }

        /// <summary>
        /// Gets the collection column class.
        /// </summary>
        /// <value>
        /// The collection column class.
        /// </value>
        public string CollectionColumnClass => "col-md-2";

        /// <summary>
        /// Gets or sets the directors.
        /// </summary>
        /// <value>
        /// The directors.
        /// </value>
        public IList<CrewResultModel> Directors { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public List<NamedItemModel> Genres { get; set; }

        /// <summary>
        /// Gets the details column class.
        /// </summary>
        /// <value>
        /// The details column class.
        /// </value>
        public string DetailsColumnClass => BelongsToCollection ? "col-md-10" : "col-md-12";

        /// <summary>
        /// Gets a value indicating whether this instance has as backdrop image.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has a backdrop image; otherwise, <c>false</c>.
        /// </value>
        public bool HasBackdrop => !string.IsNullOrWhiteSpace(BackdropImageUrl);

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
        /// Gets or sets the poster image URL at original size.
        /// </summary>
        /// <value>
        /// The poster image URL at it's original size.
        /// </value>
        public string PosterImageUrlOriginal { get; set; }

        /// <summary>
        /// Gets or sets the producers.
        /// </summary>
        /// <value>
        /// The producers.
        /// </value>
        public IList<CrewResultModel> Producers { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public IList<NamedItemModel> ProductionCompanies { get; set; }

        /// <summary>
        /// Gets or sets the profit.
        /// </summary>
        /// <value>
        /// The profit.
        /// </value>
        public string Profit { get; set; }

        /// <summary>
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the release year.
        /// </summary>
        /// <value>
        /// The release year.
        /// </value>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the revenue.
        /// </summary>
        /// <value>
        /// The revenue.
        /// </value>
        public string Revenue { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        /// <value>
        /// The runtime.
        /// </value>
        public string Runtime { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

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

        /// <summary>
        /// Gets or sets the top billed cast.
        /// </summary>
        /// <value>
        /// The top billed cast.
        /// </value>
        public IList<CastResultModel> TopBilledCast { get; set; }

        /// <summary>
        /// Gets or sets the writers.
        /// </summary>
        /// <value>
        /// The writers.
        /// </value>
        public IList<CrewResultModel> Writers { get; set; }
    }
}