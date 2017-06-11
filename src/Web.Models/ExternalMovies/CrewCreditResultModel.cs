//-----------------------------------------------------------------------
// <copyright file="CrewCreditResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Model class for a crew credit result
    /// </summary>
    /// <seealso cref="Web.Models.ExternalMovies.BasePersonCreditResultModel" />
    public class CrewCreditResultModel : BasePersonCreditResultModel
    {
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the job.
        /// </summary>
        /// <value>
        /// The job.
        /// </value>
        public string Job { get; set; }
    }
}