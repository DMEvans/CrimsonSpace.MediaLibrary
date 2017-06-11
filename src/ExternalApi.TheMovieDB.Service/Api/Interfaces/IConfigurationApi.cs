//-----------------------------------------------------------------------
// <copyright file="IConfigurationApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api.Interfaces
{
    using System;
    using ExternalApi.TheMovieDB.Domain;

    /// <summary>
    /// Configuration API interface
    /// </summary>
    public interface IConfigurationApi
    {
        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <returns>The API key</returns>
        string GetApiKey();

        /// <summary>
        /// Gets the full configuration details.
        /// </summary>
        /// <returns>Full configuration details</returns>
        ConfigurationDetails GetConfiguration();

        /// <summary>
        /// Gets the next refresh timestamp.
        /// </summary>
        /// <returns>Next refresh timestamp</returns>
        DateTime GetNextRefreshTimestamp();
    }
}