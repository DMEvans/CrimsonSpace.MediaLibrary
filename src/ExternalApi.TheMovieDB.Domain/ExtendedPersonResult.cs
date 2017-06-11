//-----------------------------------------------------------------------
// <copyright file="ExtendedPersonResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Base;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// Container class for an extended person result
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.Base.IPersonResult" />
    public class ExtendedPersonResult : BasePersonResult
    {
        /// <summary>
        /// Gets or sets the collection of names this person is also known by.
        /// </summary>
        /// <value>
        /// The collection of names this person is also known by.
        /// </value>
        [JsonProperty("also_known_as")]
        public IList<string> AlsoKnownAs { get; set; }

        /// <summary>
        /// Gets or sets the biography.
        /// </summary>
        /// <value>
        /// The biography.
        /// </value>
        [JsonProperty("biography")]
        public string Biography { get; set; }

        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        /// <value>
        /// The birthday.
        /// </value>
        [JsonProperty("birthday")]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets the credits.
        /// </summary>
        /// <value>
        /// The credits.
        /// </value>
        [JsonIgnore]
        public PersonCreditCollection Credits { get; set; }

        /// <summary>
        /// Gets or sets the death day.
        /// </summary>
        /// <value>
        /// The death day.
        /// </value>
        [JsonProperty("deathday")]
        public DateTime? Deathday { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        [JsonProperty("gender")]
        public Genders Gender { get; set; }

        /// <summary>
        /// Gets or sets the home page.
        /// </summary>
        /// <value>
        /// The home page.
        /// </value>
        [JsonProperty("homepage")]
        public string HomePage { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [JsonIgnore]
        public PersonImageCollection Images { get; set; }

        /// <summary>
        /// Gets or sets the IMDB identifier.
        /// </summary>
        /// <value>
        /// The IMDB identifier.
        /// </value>
        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this person in involved in the production of adult films
        /// </summary>
        /// <value>
        ///   <c>true</c> if this this person in involved in the production of adult films; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("adult")]
        public bool IsAdult { get; set; }

        /// <summary>
        /// Gets or sets the place of birth.
        /// </summary>
        /// <value>
        /// The place of birth.
        /// </value>
        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the popularity.
        /// </summary>
        /// <value>
        /// The popularity.
        /// </value>
        [JsonProperty("popularity")]
        public double Popularity { get; set; }
    }
}