//-----------------------------------------------------------------------
// <copyright file="BasicCollectionResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using System;
    using ExternalApi.TheMovieDB.Domain.Interfaces;
    using Newtonsoft.Json;

    /// <summary>
    /// Basic movie collection container class
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.BasicObject" />
    public class BasicCollectionResult : IBasicObject
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
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the poster path.
        /// </summary>
        /// <value>
        /// The poster path.
        /// </value>
        [JsonProperty(PropertyName = "poster_path")]
        public string PosterPath { get; set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(IBasicObject other)
        {
            return other.Id == Id;
        }
    }
}