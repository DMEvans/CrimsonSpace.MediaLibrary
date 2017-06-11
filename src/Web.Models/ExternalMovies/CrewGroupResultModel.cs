//-----------------------------------------------------------------------
// <copyright file="CrewGroupResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using System.Collections.Generic;

    /// <summary>
    /// Model class for a crew group result
    /// </summary>
    public class CrewGroupResultModel
    {
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>
        /// The members.
        /// </value>
        public IEnumerable<CrewResultModel> Members { get; set; }
    }
}