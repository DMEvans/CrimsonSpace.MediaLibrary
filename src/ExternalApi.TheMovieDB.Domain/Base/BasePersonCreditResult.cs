//-----------------------------------------------------------------------
// <copyright file="BasePersonCreditResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain.Base
{
    using Newtonsoft.Json;
    using System;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// Interface describing the properties of a person credit result
    /// </summary>
    public abstract class BasePersonCreditResult
    {
        /// <summary>
        /// Gets or sets the credit identifier.
        /// </summary>
        /// <value>
        /// The credit identifier.
        /// </value>
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// Gets or sets the episode count.
        /// </summary>
        /// <value>
        /// The episode count.
        /// </value>
        [JsonProperty("episode_count")]
        public int? EpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the first air date.
        /// </summary>
        /// <value>
        /// The first air date.
        /// </value>
        [JsonProperty("first_air_date")]
        public DateTime? FirstAirDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is adult.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is adult; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("adult")]
        public bool IsAdult { get; set; }

        /// <summary>
        /// Gets or sets the type of the media.
        /// </summary>
        /// <value>
        /// The type of the media.
        /// </value>
        [JsonProperty("media_type")]
        public MediaTypes MediaType { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the original name.
        /// </summary>
        /// <value>
        /// The name of the original name.
        /// </value>
        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        /// <summary>
        /// Gets or sets the original title.
        /// </summary>
        /// <value>
        /// The original title.
        /// </value>
        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// Gets or sets the poster path.
        /// </summary>
        /// <value>
        /// The poster path.
        /// </value>
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        /// <summary>
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}