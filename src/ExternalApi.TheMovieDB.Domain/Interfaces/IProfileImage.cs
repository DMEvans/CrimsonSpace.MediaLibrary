//-----------------------------------------------------------------------
// <copyright file="IProfileImage.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain.Interfaces
{
    /// <summary>
    /// Interface defining an object which has a profile image
    /// </summary>
    public interface IProfileImage
    {
        /// <summary>
        /// Gets or sets the profile image URL.
        /// </summary>
        /// <value>
        /// The profile image URL.
        /// </value>
        string ProfileImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL for the original size.
        /// </summary>
        /// <value>
        /// The profile image URL for the original size.
        /// </value>
        string ProfileImageUrlOriginal { get; set; }

        /// <summary>
        /// Gets or sets the profile path.
        /// </summary>
        /// <value>
        /// The profile path.
        /// </value>
        string ProfilePath { get; set; }
    }
}