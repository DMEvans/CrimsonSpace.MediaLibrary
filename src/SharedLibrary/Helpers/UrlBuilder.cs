//-----------------------------------------------------------------------
// <copyright file="UrlBuilder.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace SharedLibrary.Helpers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Helper class for building URLs
    /// </summary>
    public class UrlBuilder
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="UrlBuilder"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        public UrlBuilder(string baseUrl)
        {
            Parameters = new Dictionary<string, string>();
            BaseURL = baseUrl;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        protected string BaseURL { get; private set; }
        
        /// <summary>
        /// Gets the URL GET parameters.
        /// </summary>
        /// <value>
        /// The URL GET parameters.
        /// </value>
        protected Dictionary<string, string> Parameters { get; private set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Adds a GET parameter.
        /// </summary>
        /// <param name="name">The GET parameter name.</param>
        /// <param name="value">The GET parameter value.</param>
        public void AddParameter(string name, string value)
        {
            Parameters.Add(name, value);
        }

        /// <summary>
        /// Adds a GET parameter.
        /// </summary>
        /// <param name="name">The GET parameter name.</param>
        /// <param name="value">The GET parameter value.</param>
        public void AddParameter(string name, int value)
        {
            Parameters.Add(name, value.ToString());
        }

        /// <summary>
        /// Builds the URL.
        /// </summary>
        /// <returns>The URL</returns>
        public string BuildUrl()
        {
            var builder = new StringBuilder(BaseURL);
            builder.Append("?");
            builder.Append(string.Join("&", Parameters.Select(x => x.Key + "=" + x.Value)));

            return builder.ToString();
        }

        #endregion Public Methods
    }
}