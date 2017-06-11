//-----------------------------------------------------------------------
// <copyright file="BasePersonResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Abstract model class for a person result
    /// </summary>
    /// <seealso cref="Web.Models.ExternalMovies.NamedItemModel" />
    public abstract class BasePersonResultModel : NamedItemModel
    {
        /// <summary>
        /// Gets or sets the profile image URL.
        /// </summary>
        /// <value>
        /// The profile image URL.
        /// </value>
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL for the original size.
        /// </summary>
        /// <value>
        /// The profile image URL for the original size.
        /// </value>
        public string ProfileImageUrlOriginal { get; set; }
    }
}