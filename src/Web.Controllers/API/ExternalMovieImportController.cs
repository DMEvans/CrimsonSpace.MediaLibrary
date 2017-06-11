//-----------------------------------------------------------------------
// <copyright file="ExternalMovieImportController.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers.API
{
    using ExternalApi.TheMovieDB.Service.Api;
    using Library.Domain.Models;
    using Library.Service;
    using System.Net.Http;
    using System.Web.Http;
    using Web.Models.Dependencies;
    using Web.Models.ExternalMovies;

    /// <summary>
    /// API controller class for external movie import actions
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ExternalMovieImportController : ApiController
    {
        #region Members

        /// <summary>
        /// The dependencies
        /// </summary>
        private ExternalMovieControllerDependencies _dependencies;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ExternalMovieImportController"/> class.
        /// </summary>
        /// <param name="dependencies">The dependencies.</param>
        public ExternalMovieImportController(ExternalMovieControllerDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets the external movie import details.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Import movie result model</returns>
        public ImportMovieResultModel Get(int id)
        {
            var movieDetails = _dependencies.MovieApi.GetFullMovieDetails(id);

            var model = _dependencies.ModelFactory.CreateImport(movieDetails);

            return model;
        }

        /// <summary>
        /// Add an external movie to the database.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <returns>Response message</returns>
        [HttpPost]
        public HttpResponseMessage Post([FromBody]ImportMovieModel details)
        {
            return new HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
        }

        #endregion Public Methods
    }
}