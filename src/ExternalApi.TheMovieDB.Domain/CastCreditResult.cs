//-----------------------------------------------------------------------
// <copyright file="CastCreditResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Base;
    using Newtonsoft.Json;

    /// <summary>
    /// Container class for a cast credit result
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.Base.BasePersonCreditResult" />
    public class CastCreditResult : BasePersonCreditResult
    {
        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>
        /// The character.
        /// </value>
        [JsonProperty("character")]
        public string Character { get; set; }
    }
}