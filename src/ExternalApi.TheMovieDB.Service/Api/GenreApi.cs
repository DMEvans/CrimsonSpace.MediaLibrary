//-----------------------------------------------------------------------
// <copyright file="GenreApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api
{
    using ExternalApi.TheMovieDB.Service.Api.Interfaces;
    using Newtonsoft.Json;
    using SharedLibrary.Helpers;
    using System;
    using System.Collections.Generic;
    using TheMovieDB.Domain;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// Genre API handler class
    /// </summary>
    public class GenreApi : IGenreApi
    {
        #region Members

        /// <summary>
        /// The configuration API handler
        /// </summary>
        private IConfigurationApi _configurationApi;

        /// <summary>
        /// The movie genre list
        /// </summary>
        private IEnumerable<GenreResult> _movieGenres;

        /// <summary>
        /// The TV genre list
        /// </summary>
        private IEnumerable<GenreResult> _tvGenres;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="GenreApi"/> class.
        /// </summary>
        /// <param name="configurationApi">The configuration API.</param>
        public GenreApi(IConfigurationApi configurationApi)
        {
            _configurationApi = configurationApi;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets the movie genres.
        /// </summary>
        /// <returns>The movie genres</returns>
        public IEnumerable<GenreResult> GetMovieGenres()
        {
            ValidateGenres();

            return _movieGenres;
        }

        /// <summary>
        /// Gets the TV genres.
        /// </summary>
        /// <returns>The TV genres</returns>
        public IEnumerable<GenreResult> GetTvGenres()
        {
            ValidateGenres();

            return _tvGenres;
        }

        #endregion Public Methods

        #region Protected Methods

        /// <summary>
        /// Gets the genre list.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <returns>The genre list</returns>
        protected IEnumerable<GenreResult> GetGenreList(string baseUrl)
        {
            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());
            urlBuilder.AddParameter("language", "en-GB");

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var genreListResult = JsonConvert.DeserializeObject<GenreListResult>(apiResponse);

            return genreListResult.Genres;
        }

        /// <summary>
        /// Validates the genres.
        /// </summary>
        protected void ValidateGenres()
        {
            var nextRefresh = _configurationApi.GetNextRefreshTimestamp();

            if (_movieGenres == null || _tvGenres == null || DateTime.Now >= nextRefresh)
            {
                _movieGenres = GetGenreList(ApiUrls.Movie.Genres);
                _tvGenres = GetGenreList(ApiUrls.TV.Genres);
            }
        }

        #endregion Protected Methods
    }
}