//-----------------------------------------------------------------------
// <copyright file="MovieApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api
{
    using ExternalApi.TheMovieDB.Service.Api.Interfaces;
    using ExternalApi.TheMovieDB.Service.Helpers;
    using Newtonsoft.Json;
    using SharedLibrary.Helpers;
    using TheMovieDB.Domain;
    using static ExternalApi.TheMovieDB.Domain.Constants;

    /// <summary>
    /// Movie API handler class
    /// </summary>
    public class MovieApi : IMovieApi
    {
        #region Members

        /// <summary>
        /// The configuration API handler
        /// </summary>
        private IConfigurationApi _configurationApi;

        /// <summary>
        /// The image helper
        /// </summary>
        private ImageUrlHelper _imageHelper;

        #endregion Members

        #region Constuctors

        /// <summary>
        /// Initialises a new instance of the <see cref="MovieApi"/> class.
        /// </summary>
        /// <param name="configurationApi">The configuration API.</param>
        /// <param name="imageHelper">The image helper.</param>
        public MovieApi(IConfigurationApi configurationApi, ImageUrlHelper imageHelper)
        {
            _configurationApi = configurationApi;
            _imageHelper = imageHelper;
        }

        #endregion Constuctors

        #region Public Methods

        /// <summary>
        /// Gets the collection details.
        /// </summary>
        /// <param name="collectionId">The collection identifier.</param>
        /// <returns>The collection details</returns>
        public ExtendedCollectionResult GetCollection(int collectionId)
        {
            var collectionDetails = GetCollectionDetails(collectionId);
            return collectionDetails;
        }

        /// <summary>
        /// Gets the full movie details.
        /// </summary>
        /// <param name="movieId">The movie identifier.</param>
        /// <returns>Full movie details</returns>
        public ExtendedMovieResult GetFullMovieDetails(int movieId)
        {
            var movieDetails = GetMovieDetails(movieId);
            movieDetails.Credits = GetMovieCredits(movieId);

            return movieDetails;
        }

        /// <summary>
        /// Searches the movies.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="page">The page number.</param>
        /// <returns>Search results</returns>
        public MovieSearchResult SearchMovies(string query, int page)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new MovieSearchResult();
            }

            string baseUrl = ApiUrls.Movie.Search;

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());
            urlBuilder.AddParameter("query", query);
            urlBuilder.AddParameter("page", page);
            urlBuilder.AddParameter("language", "en-GB");

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var movieSearchResult = JsonConvert.DeserializeObject<MovieSearchResult>(apiResponse);

            return movieSearchResult;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Gets the collection details.
        /// </summary>
        /// <param name="collectionId">The collection identifier.</param>
        /// <returns>The collection details</returns>
        private ExtendedCollectionResult GetCollectionDetails(int collectionId)
        {
            string baseUrl = string.Format(ApiUrls.Collection.Details, collectionId);

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var collectionDetails = JsonConvert.DeserializeObject<ExtendedCollectionResult>(apiResponse);

            return collectionDetails;
        }

        /// <summary>
        /// Gets the movie credits.
        /// </summary>
        /// <param name="movieId">The movie identifier.</param>
        /// <returns>Movie credits</returns>
        private MovieCreditResult GetMovieCredits(int movieId)
        {
            string baseUrl = string.Format(ApiUrls.Movie.Credits, movieId);

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var credits = JsonConvert.DeserializeObject<MovieCreditResult>(apiResponse);

            return credits;
        }

        /// <summary>
        /// Gets the movie details.
        /// </summary>
        /// <param name="movieId">The movie identifier.</param>
        /// <returns>Movie details</returns>
        private ExtendedMovieResult GetMovieDetails(int movieId)
        {
            string baseUrl = string.Format(ApiUrls.Movie.Details, movieId);

            var urlBuilder = new UrlBuilder(baseUrl);
            urlBuilder.AddParameter("api_key", _configurationApi.GetApiKey());
            urlBuilder.AddParameter("language", "en-GB");

            var apiResponse = ApiHelper.MakeApiRequest(urlBuilder.BuildUrl());

            var movieDetails = JsonConvert.DeserializeObject<ExtendedMovieResult>(apiResponse);

            return movieDetails;
        }

        #endregion Private Methods
    }
}