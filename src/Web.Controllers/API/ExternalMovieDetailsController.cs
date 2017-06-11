//-----------------------------------------------------------------------
// <copyright file="ExternalMovieDetailsController.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers.API
{
    using System.Web.Http;
    using Web.Models.Dependencies;
    using Web.Models.ExternalMovies;

    /// <summary>
    /// API controller class for external movie details
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ExternalMovieDetailsController : ApiController
    {
        #region Members

        /// <summary>
        /// The dependencies
        /// </summary>
        private ExternalMovieControllerDependencies _dependencies;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ExternalMovieDetailsController"/> class.
        /// </summary>
        /// <param name="dependencies">The dependencies.</param>
        public ExternalMovieDetailsController(ExternalMovieControllerDependencies dependencies)
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
        public ExtendedMovieResultModel Get(int id)
        {
            var movieDetails = _dependencies.MovieApi.GetFullMovieDetails(id);

            var model = _dependencies.ModelFactory.Create(movieDetails);

            return model;
        }

        #endregion Public Methods
    }
}