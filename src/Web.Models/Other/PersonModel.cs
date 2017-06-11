//-----------------------------------------------------------------------
// <copyright file="PersonModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.Other
{
    using ExternalApi.TheMovieDB.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Person model
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The person details
        /// </summary>
        private ExtendedPersonResult _personDetails;

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="PersonModel"/> class.
        /// </summary>
        /// <param name="personDetails">The person details.</param>
        public PersonModel(ExtendedPersonResult personDetails)
        {
            _personDetails = personDetails;
        }

        #endregion Constructors

        /// <summary>
        /// Gets the biography.
        /// </summary>
        /// <value>
        /// The biography.
        /// </value>
        public string Biography => _personDetails.Biography;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name => _personDetails.Name;

        /// <summary>
        /// Gets the cast credits.
        /// </summary>
        /// <value>
        /// The cast credits.
        /// </value>
        public IEnumerable<CastCreditResult> CastCredits => _personDetails.Credits.Cast;

        /// <summary>
        /// Gets the crew credits.
        /// </summary>
        /// <value>
        /// The crew credits.
        /// </value>
        public IEnumerable<CrewCreditResult> CrewCredits => _personDetails.Credits.Crew;

        /// <summary>
        /// Gets a value indicating whether this person has cast credits.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this person has cast credits; otherwise, <c>false</c>.
        /// </value>
        public bool HasCastCredits => CastCredits.Any();

        /// <summary>
        /// Gets a value indicating whether this person has crew credits.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this person has crew credits; otherwise, <c>false</c>.
        /// </value>
        public bool HasCrewCredits => CrewCredits.Any();

        /// <summary>
        /// Gets the profile images.
        /// </summary>
        /// <value>
        /// The profile images.
        /// </value>
        public IEnumerable<ImageResult> ProfileImages => _personDetails.Images.Profiles;

        /// <summary>
        /// Gets the height of the images based on the height of the tallest image.
        /// </summary>
        /// <value>
        /// The height of the images.
        /// </value>
        public int ImageHeight => (int)ProfileImages.Max(x => 185 / x.AspectRatio);
    }
}