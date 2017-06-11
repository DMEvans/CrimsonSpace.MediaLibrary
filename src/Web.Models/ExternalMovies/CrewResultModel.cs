//-----------------------------------------------------------------------
// <copyright file="CrewResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Model class for a movie crew result
    /// </summary>
    /// <seealso cref="Web.Models.ExternalMovies.BasePersonResultModel" />
    public class CrewResultModel : BasePersonResultModel
    {
        /// <summary>
        /// Gets or sets the job title.
        /// </summary>
        /// <value>
        /// The job title.
        /// </value>
        public string Job { get; set; }
    }
}