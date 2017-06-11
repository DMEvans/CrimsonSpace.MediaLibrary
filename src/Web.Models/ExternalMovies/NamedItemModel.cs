//-----------------------------------------------------------------------
// <copyright file="NamedItemModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Model class for a named item
    /// </summary>
    public class NamedItemModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}