//-----------------------------------------------------------------------
// <copyright file="MovieSearchResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Model class for a movie search result
    /// </summary>
    public class MovieSearchResultModel
    {
        /// <summary>
        /// Gets a value indicating whether this instance has results.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has results; otherwise, <c>false</c>.
        /// </value>
        public bool HasResults => Results != null && Results.Any();

        /// <summary>
        /// Gets or sets the total results.
        /// </summary>
        /// <value>
        /// The total results.
        /// </value>
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the total pages.
        /// </summary>
        /// <value>
        /// The total pages.
        /// </value>
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        public IEnumerable<BasicMovieResultModel> Results { get; set; }
    }
}