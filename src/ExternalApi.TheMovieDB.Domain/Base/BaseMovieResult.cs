//-----------------------------------------------------------------------
// <copyright file="BaseMovieResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain.Base
{
    using ExternalApi.TheMovieDB.Domain.Interfaces;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Movie result base container class
    /// </summary>
    public abstract class BaseMovieResult
    {
        /// <summary>
        /// Gets or sets the backdrop path.
        /// </summary>
        /// <value>
        /// The backdrop path.
        /// </value>
        [JsonProperty(PropertyName = "backdrop_path")]
        public string BackdropPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has video.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has video; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty(PropertyName = "video")]
        public bool HasVideo { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is adult.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is adult; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty(PropertyName = "adult")]
        public bool IsAdult { get; set; }

        /// <summary>
        /// Gets or sets the original language.
        /// </summary>
        /// <value>
        /// The original language.
        /// </value>
        [JsonProperty(PropertyName = "original_language")]
        public string OriginalLanguage { get; set; }

        /// <summary>
        /// Gets or sets the original title.
        /// </summary>
        /// <value>
        /// The original title.
        /// </value>
        [JsonProperty(PropertyName = "original_title")]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [JsonProperty(PropertyName = "overview")]
        public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the popularity.
        /// </summary>
        /// <value>
        /// The popularity.
        /// </value>
        [JsonProperty(PropertyName = "popularity")]
        public decimal Popularity { get; set; }

        /// <summary>
        /// Gets or sets the poster path.
        /// </summary>
        /// <value>
        /// The poster path.
        /// </value>
        [JsonProperty(PropertyName = "poster_path")]
        public string PosterPath { get; set; }

        /// <summary>
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        [JsonProperty(PropertyName = "release_date")]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the vote average.
        /// </summary>
        /// <value>
        /// The vote average.
        /// </value>
        [JsonProperty(PropertyName = "vote_average")]
        public decimal VoteAverage { get; set; }

        /// <summary>
        /// Gets or sets the vote count.
        /// </summary>
        /// <value>
        /// The vote count.
        /// </value>
        [JsonProperty(PropertyName = "vote_count")]
        public int VoteCount { get; set; }
    }
}