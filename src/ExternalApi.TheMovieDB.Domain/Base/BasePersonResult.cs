//-----------------------------------------------------------------------
// <copyright file="BasePersonResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain.Base
{
    using System;
    using ExternalApi.TheMovieDB.Domain.Interfaces;
    using Newtonsoft.Json;

    /// <summary>
    /// Person result container class
    /// </summary>
    public abstract class BasePersonResult
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the profile path.
        /// </summary>
        /// <value>
        /// The profile path.
        /// </value>
        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(IBasicObject other)
        {
            return Id == other.Id;
        }
    }
}