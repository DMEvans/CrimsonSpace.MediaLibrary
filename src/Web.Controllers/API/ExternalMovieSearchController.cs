//-----------------------------------------------------------------------
// <copyright file="ExternalMovieSearchController.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers.API
{
    using ExternalApi.TheMovieDB.Service.Api;
    using System.Web.Http;
    using Web.Models.Dependencies;
    using Web.Models.ExternalMovies;

    /// <summary>
    /// API controller class for import movie search and movie details
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ExternalMovieSearchController : ApiController
    {
        #region Members

        /// <summary>
        /// The dependencies
        /// </summary>
        private ExternalMovieControllerDependencies _dependencies;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ExternalMovieSearchController"/> class.
        /// </summary>
        /// <param name="dependencies">The dependencies.</param>
        public ExternalMovieSearchController(ExternalMovieControllerDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Search for movies.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="page">The page.</param>
        /// <returns>Movie search result model</returns>
        public MovieSearchResultModel Get(string query, int page = 1)
        {
            var searchResult = _dependencies.MovieApi.SearchMovies(query, page);

            var model = _dependencies.ModelFactory.Create(searchResult);

            return model;
        }

        #endregion Public Methods
    }
}