//-----------------------------------------------------------------------
// <copyright file="BasePersonCreditResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Abstract model class for person credit results
    /// </summary>
    public abstract class BasePersonCreditResultModel
    {
        /// <summary>
        /// Gets or sets the credit identifier.
        /// </summary>
        /// <value>
        /// The credit identifier.
        /// </value>
        public string CreditId { get; set; }

        /// <summary>
        /// Gets or sets the episode count.
        /// </summary>
        /// <value>
        /// The episode count.
        /// </value>
        public int? EpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the first air year.
        /// </summary>
        /// <value>
        /// The first air year.
        /// </value>
        public int? FirstAirYear { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has poster image.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has poster image; otherwise, <c>false</c>.
        /// </value>
        public bool HasPosterImage => !string.IsNullOrWhiteSpace(PosterImageUrl);

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is movie credit.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is movie credit; otherwise, <c>false</c>.
        /// </value>
        public bool IsMovieCredit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is TV credit.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is TV credit; otherwise, <c>false</c>.
        /// </value>
        public bool IsTvCredit { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the poster image URL.
        /// </summary>
        /// <value>
        /// The poster image URL.
        /// </value>
        public string PosterImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public int? ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
    }
}