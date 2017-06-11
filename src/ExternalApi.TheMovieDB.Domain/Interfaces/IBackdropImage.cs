//-----------------------------------------------------------------------
// <copyright file="IBackdropImage.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain.Interfaces
{
    /// <summary>
    /// Interface defining an object which has a backdrop image
    /// </summary>
    public interface IBackdropImage
    {
        /// <summary>
        /// Gets or sets the backdrop path.
        /// </summary>
        /// <value>
        /// The backdrop path.
        /// </value>
        string BackdropPath { get; set; }

        /// <summary>
        /// Gets or sets the backdrop image URL.
        /// </summary>
        /// <value>
        /// The backdrop image URL.
        /// </value>
        string BackdropImageUrl { get; set; }
    }
}