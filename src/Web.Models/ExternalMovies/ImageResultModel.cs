//-----------------------------------------------------------------------
// <copyright file="ImageResultModel.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.ExternalMovies
{
    /// <summary>
    /// Model class for an image result
    /// </summary>
    public class ImageResultModel
    {
        /// <summary>
        /// Gets or sets the aspect ratio.
        /// </summary>
        /// <value>
        /// The aspect ratio.
        /// </value>
        public double AspectRatio { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>
        /// The image URL.
        /// </value>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the image URL of the original size.
        /// </summary>
        /// <value>
        /// The image URL if the original size.
        /// </value>
        public string ImageUrlOriginal { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }
    }
}