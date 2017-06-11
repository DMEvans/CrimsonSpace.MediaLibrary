//-----------------------------------------------------------------------
// <copyright file="ImportMovieModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Domain.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Model class for imported movie
    /// </summary>
    public class ImportMovieModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether to include the backdrop image.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the backdrop image should be included; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeBackdropImage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include the poster image.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the poster image should be included; otherwise, <c>false</c>.
        /// </value>
        public bool IncludePosterImage { get; set; }

        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        /// <value>
        /// The external identifier.
        /// </value>
        public int ExternalId { get; set; }
    }
}