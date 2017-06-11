//-----------------------------------------------------------------------
// <copyright file="ExternalMoviePersonController.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers.API
{
    using System.Web.Http;
    using Web.Models.Dependencies;
    using Web.Models.ExternalMovies;

    /// <summary>
    /// API controller class for import movie cast/crew
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ExternalMoviePersonController : ApiController
    {
        #region Members

        /// <summary>
        /// The dependencies
        /// </summary>
        private ExternalMovieControllerDependencies _dependencies;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ExternalMoviePersonController"/> class.
        /// </summary>
        /// <param name="dependencies">The dependencies.</param>
        public ExternalMoviePersonController(ExternalMovieControllerDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Extended person result model</returns>
        public ExtendedPersonResultModel Get(int id)
        {
            var personDetails = _dependencies.PersonApi.GetFullPersonDetails(id);

            var model = _dependencies.ModelFactory.Create(personDetails);

            return model;
        }

        #endregion Public Methods
    }
}