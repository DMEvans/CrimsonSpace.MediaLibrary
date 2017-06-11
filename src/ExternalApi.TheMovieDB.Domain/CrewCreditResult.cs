//-----------------------------------------------------------------------
// <copyright file="CrewCreditResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using ExternalApi.TheMovieDB.Domain.Base;
    using Newtonsoft.Json;

    /// <summary>
    /// Container class for a crew credit result
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.Base.BasePersonCreditResult" />
    public class CrewCreditResult : BasePersonCreditResult
    {
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        [JsonProperty("department")]
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the job.
        /// </summary>
        /// <value>
        /// The job.
        /// </value>
        [JsonProperty("job")]
        public string Job { get; set; }
    }
}