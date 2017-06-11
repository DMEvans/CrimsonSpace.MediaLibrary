//-----------------------------------------------------------------------
// <copyright file="CrewResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Base;
    using Newtonsoft.Json;

    /// <summary>
    /// Crew member result container class
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.PersonResult" />
    public class CrewResult : BasePersonResult
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
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        [JsonProperty("department")]
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the job title.
        /// </summary>
        /// <value>
        /// The job title.
        /// </value>
        [JsonProperty("job")]
        public string Job { get; set; }
    }
}
