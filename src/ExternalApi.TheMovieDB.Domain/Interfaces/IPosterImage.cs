//-----------------------------------------------------------------------
// <copyright file="IPosterImage.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain.Interfaces
{
    /// <summary>
    /// Interface defining an object which has a poster image
    /// </summary>
    public interface IPosterImage
    {
        /// <summary>
        /// Gets or sets the poster image URL.
        /// </summary>
        /// <value>
        /// The poster image URL.
        /// </value>
        string PosterImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the poster image URL for the original size.
        /// </summary>
        /// <value>
        /// The poster image URL for the original size.
        /// </value>
        string PosterImageUrlOriginal { get; set; }

        /// <summary>
        /// Gets or sets the poster path.
        /// </summary>
        /// <value>
        /// The poster path.
        /// </value>
        string PosterPath { get; set; }
    }
}