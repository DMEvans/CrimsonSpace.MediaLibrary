//-----------------------------------------------------------------------
// <copyright file="ConfigurationApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api
{
    using ExternalApi.Data.Interfaces;
    using ExternalApi.TheMovieDB.Domain;
    using ExternalApi.TheMovieDB.Service.Api.Interfaces;
    using Newtonsoft.Json;
    using SharedLibrary.Exceptions;
    using SharedLibrary.Helpers;
    using System;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// External API configuration handler class
    /// </summary>
    public class ConfigurationApi : IConfigurationApi
    {
        #region Members

        /// <summary>
        /// The configuration details
        /// </summary>
        private ConfigurationDetails _configurationDetails;

        /// <summary>
        /// The date time to next refresh from the API
        /// </summary>
        private DateTime? _nextRefresh;

        /// <summary>
        /// The repository
        /// </summary>
        private IExternalSourceRepository _repository;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ConfigurationApi"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ConfigurationApi(IExternalSourceRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <returns>The API key</returns>
        public string GetApiKey()
        {
            ValidateConfigurationDetails();

            return _configurationDetails.ApiKey;
        }

        /// <summary>
        /// Gets the full configuration details.
        /// </summary>
        /// <returns>Full configuration details</returns>
        public ConfigurationDetails GetConfiguration()
        {
            ValidateConfigurationDetails();

            return _configurationDetails;
        }

        /// <summary>
        /// Gets the next refresh timestamp.
        /// </summary>
        /// <returns>Next refresh timestamp</returns>
        public DateTime GetNextRefreshTimestamp()
        {
            ValidateConfigurationDetails();

            return _nextRefresh.GetValueOrDefault();
        }

        #endregion Public Methods

        #region Protected Methods

        /// <summary>
        /// Gets the configuration from API.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <returns>The API response</returns>
        protected string GetConfigurationFromApi(string apiKey)
        {
            var baseUrl = ApiUrls.Configuration.Details;

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", apiKey);

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            return apiResponse;
        }

        /// <summary>
        /// Gets the configuration from repository.
        /// </summary>
        /// <exception cref="ItemNotFoundException">No matching external source was found</exception>
        protected void GetConfigurationFromRepository()
        {
            var externalSource = _repository.GetSingle(x => x.Name == Constants.ExternalSourceName);

            if (externalSource == null)
            {
                throw new ItemNotFoundException();
            }

            _nextRefresh = externalSource.ConfigurationTimestamp.AddMinutes(externalSource.ConfigurationRefreshMinutes);

            if (externalSource.Configuration == null || DateTime.Now >= _nextRefresh.GetValueOrDefault())
            {
                externalSource.Configuration = GetConfigurationFromApi(externalSource.ApiKey);
                externalSource.ConfigurationTimestamp = DateTime.Now;
                _repository.Update(externalSource);
            }

            _configurationDetails = JsonConvert.DeserializeObject<ConfigurationDetails>(externalSource.Configuration);
            _configurationDetails.ApiKey = externalSource.ApiKey;
        }

        /// <summary>
        /// Validates the configuration details.
        /// </summary>
        protected void ValidateConfigurationDetails()
        {
            if (_configurationDetails == null || DateTime.Now >= _nextRefresh)
            {
                GetConfigurationFromRepository();
            }
        }

        #endregion Protected Methods
    }
}