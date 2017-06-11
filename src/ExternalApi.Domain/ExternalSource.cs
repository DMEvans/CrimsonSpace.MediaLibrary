//-----------------------------------------------------------------------
// <copyright file="ExternalSource.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.Domain
{
    using SharedLibrary.Objects;
    using System;

    /// <summary>
    /// External source entity class
    /// </summary>
    /// <seealso cref="SharedLibrary.Objects.BaseEntity" />
    public class ExternalSource : BaseEntity
    {
        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the API configuration data.
        /// </summary>
        /// <value>
        /// The API configuration data.
        /// </value>
        public string Configuration { get; set; }

        /// <summary>
        /// Gets or sets the duration in minutes between each refresh of the configuration from the source API.
        /// </summary>
        /// <value>
        /// The duration in minutes between each refresh of the configuration from the source API.
        /// </value>
        public int ConfigurationRefreshMinutes { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the last API configuration data refresh.
        /// </summary>
        /// <value>
        /// The timestamp of the last API configuration data refresh.
        /// </value>
        public DateTime ConfigurationTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the name of the API.
        /// </summary>
        /// <value>
        /// The name of the API.
        /// </value>
        public string Name { get; set; }
    }
}