//-----------------------------------------------------------------------
// <copyright file="ExtendedPersonResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Model class for an extended person result
    /// </summary>
    public class ExtendedPersonResultModel
    {
        /// <summary>
        /// Gets or sets the aliases.
        /// </summary>
        /// <value>
        /// The aliases.
        /// </value>
        public IEnumerable<string> Aliases { get; set; }

        /// <summary>
        /// Gets or sets the biography.
        /// </summary>
        /// <value>
        /// The biography.
        /// </value>
        public string Biography { get; set; }

        /// <summary>
        /// Gets or sets the cast credits.
        /// </summary>
        /// <value>
        /// The cast credits.
        /// </value>
        public IEnumerable<CastCreditResultModel> CastCredits { get; set; }

        /// <summary>
        /// Gets or sets the crew credits.
        /// </summary>
        /// <value>
        /// The crew credits.
        /// </value>
        public IEnumerable<CrewCreditResultModel> CrewCredits { get; set; }

        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        /// <value>
        /// The birthday.
        /// </value>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets the death day.
        /// </summary>
        /// <value>
        /// The death day.
        /// </value>
        public DateTime? Deathday { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has images.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has images; otherwise, <c>false</c>.
        /// </value>
        public bool HasImages => Images.Any();

        /// <summary>
        /// Gets a value indicating whether this instance has birthday.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has birthday; otherwise, <c>false</c>.
        /// </value>
        public bool HasBirthday => Birthday.HasValue;

        /// <summary>
        /// Gets a value indicating whether this instance has cast credits.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has cast credits; otherwise, <c>false</c>.
        /// </value>
        public bool HasCastCredits => CastCredits.Any();

        /// <summary>
        /// Gets a value indicating whether this instance has crew credits.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has crew credits; otherwise, <c>false</c>.
        /// </value>
        public bool HasCrewCredits => CrewCredits.Any();

        /// <summary>
        /// Gets a value indicating whether this instance has home page.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has home page; otherwise, <c>false</c>.
        /// </value>
        public bool HasHomePage => !string.IsNullOrWhiteSpace(HomePage);

        /// <summary>
        /// Gets or sets the home page.
        /// </summary>
        /// <value>
        /// The home page.
        /// </value>
        public string HomePage { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public IEnumerable<ImageResultModel> Images { get; set; }

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
        /// Gets a value indicating whether this instance is deceased.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is deceased; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeceased => Deathday.HasValue;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the place of birth.
        /// </summary>
        /// <value>
        /// The place of birth.
        /// </value>
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL.
        /// </summary>
        /// <value>
        /// The profile image URL.
        /// </value>
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL original.
        /// </summary>
        /// <value>
        /// The profile image URL original.
        /// </value>
        public string ProfileImageUrlOriginal { get; set; }
    }
}