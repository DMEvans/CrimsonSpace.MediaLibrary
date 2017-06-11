//-----------------------------------------------------------------------
// <copyright file="CastResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Base;
    using Newtonsoft.Json;

    /// <summary>
    /// Cast member result container class
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.PersonResult" />
    public class CastResult : BasePersonResult
    {
        /// <summary>
        /// Gets or sets the cast identifier.
        /// </summary>
        /// <value>
        /// The cast identifier.
        /// </value>
        [JsonProperty("cast_id")]
        public int CastId { get; set; }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>
        /// The character.
        /// </value>
        [JsonProperty("character")]
        public string Character { get; set; }

        /// <summary>
        /// Gets or sets the credit identifier.
        /// </summary>
        /// <value>
        /// The credit identifier.
        /// </value>
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        [JsonProperty("order")]
        public int Order { get; set; }
    }
}
