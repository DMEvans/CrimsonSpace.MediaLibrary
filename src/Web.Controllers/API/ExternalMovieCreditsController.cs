//-----------------------------------------------------------------------
// <copyright file="ExternalMovieCreditsController.cs" company="Crimson Space Media">
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
    /// API controller class for import movie credits
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ExternalMovieCreditsController : ApiController
    {
        #region Members

        /// <summary>
        /// The dependencies
        /// </summary>
        private ExternalMovieControllerDependencies _dependencies;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ExternalMovieCreditsController"/> class.
        /// </summary>
        /// <param name="dependencies">The dependencies.</param>
        public ExternalMovieCreditsController(ExternalMovieControllerDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Get movie details.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Movie details result model</returns>
        public FullCreditsResultModel Get(int id)
        {
            var movieDetails = _dependencies.MovieApi.GetFullMovieDetails(id);

            var model = _dependencies.ModelFactory.CreateCredits(movieDetails);

            return model;
        }

        #endregion Public Methods
    }
}