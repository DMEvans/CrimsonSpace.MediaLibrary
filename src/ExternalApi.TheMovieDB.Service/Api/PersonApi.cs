//-----------------------------------------------------------------------
// <copyright file="PersonApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api
{
    using ExternalApi.TheMovieDB.Domain;
    using ExternalApi.TheMovieDB.Service.Api.Interfaces;
    using Newtonsoft.Json;
    using SharedLibrary.Helpers;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// Person API handler class
    /// </summary>
    public class PersonApi : IPersonApi
    {
        #region Members

        /// <summary>
        /// The configuration API handler
        /// </summary>
        private ConfigurationApi _configurationApi;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="PersonApi"/> class.
        /// </summary>
        /// <param name="configurationApi">The configuration API.</param>
        public PersonApi(ConfigurationApi configurationApi)
        {
            _configurationApi = configurationApi;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets the full person details.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Person details</returns>
        public ExtendedPersonResult GetFullPersonDetails(int personId)
        {
            var person = GetPersonDetails(personId);
            person.Credits = GetPersonCredits(personId);
            person.Images = GetPersonImages(personId);

            return person;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets the person credits.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Person credits</returns>
        private PersonCreditCollection GetPersonCredits(int personId)
        {
            string baseUrl = string.Format(ApiUrls.Person.Credits, personId);

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var credits = JsonConvert.DeserializeObject<PersonCreditCollection>(apiResponse);

            return credits;
        }

        /// <summary>
        /// Gets the person details.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Person details</returns>
        private ExtendedPersonResult GetPersonDetails(int personId)
        {
            string baseUrl = string.Format(ApiUrls.Person.Details, personId);

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var person = JsonConvert.DeserializeObject<ExtendedPersonResult>(apiResponse);

            return person;
        }

        /// <summary>
        /// Gets the person images.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Person images</returns>
        private PersonImageCollection GetPersonImages(int personId)
        {
            string baseUrl = string.Format(ApiUrls.Person.Images, personId);

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var images = JsonConvert.DeserializeObject<PersonImageCollection>(apiResponse);

            return images;
        }

        #endregion Private Methods
    }
}