//-----------------------------------------------------------------------
// <copyright file="ImageUrlHelper.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Helpers
{
    using ExternalApi.TheMovieDB.Domain;
    using ExternalApi.TheMovieDB.Service.Api;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// Image Url helper class
    /// </summary>
    public class ImageUrlHelper
    {
        #region Members

        /// <summary>
        /// The configuration details
        /// </summary>
        private ConfigurationDetails _configuration;

        /// <summary>
        /// The configuration API handler
        /// </summary>
        private ConfigurationApi _configurationApi;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ImageUrlHelper"/> class.
        /// </summary>
        /// <param name="configurationApi">The configuration API handler.</param>
        public ImageUrlHelper(ConfigurationApi configurationApi)
        {
            _configurationApi = configurationApi;

            _configuration = _configurationApi.GetConfiguration();
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets the image path.
        /// </summary>
        /// <param name="imageType">Type of the image.</param>
        /// <param name="imageSize">Size of the image.</param>
        /// <returns>The image path</returns>
        public string GetImagePath(ImageTypes imageType, ImageSizes imageSize)
        {
            var builder = new StringBuilder();
            builder.Append(_configuration.Images.SecureBaseUrl);

            string sizeValue = string.Empty;

            switch (imageType)
            {
                case ImageTypes.Backdrop:
                    sizeValue = GetImageSize(_configuration.Images.BackdropSizes, imageSize);
                    break;

                case ImageTypes.Logo:
                    sizeValue = GetImageSize(_configuration.Images.LogoSizes, imageSize);
                    break;

                case ImageTypes.Poster:
                    sizeValue = GetImageSize(_configuration.Images.PosterSizes, imageSize);
                    break;

                case ImageTypes.Profile:
                    sizeValue = GetImageSize(_configuration.Images.ProfileSizes, imageSize);
                    break;

                case ImageTypes.Still:
                    sizeValue = sizeValue = GetImageSize(_configuration.Images.StillSizes, imageSize);
                    break;
            }

            builder.Append(sizeValue);

            return builder.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <param name="sizes">The sizes.</param>
        /// <param name="imageSize">Size of the image.</param>
        /// <returns>Image size</returns>
        private string GetImageSize(List<string> sizes, ImageSizes imageSize)
        {
            var middleIndex = (int)Math.Floor((decimal)(sizes.Count / 2));

            var returnIndex = middleIndex + (int)imageSize;

            if (returnIndex < 0)
            {
                returnIndex = 0;
            }
            else if (returnIndex > (sizes.Count - 1))
            {
                returnIndex = sizes.Count - 1;
            }

            return sizes[returnIndex];
        }

        #endregion Private Methods
    }
}