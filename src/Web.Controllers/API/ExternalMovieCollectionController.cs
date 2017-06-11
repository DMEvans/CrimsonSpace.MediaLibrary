//-----------------------------------------------------------------------
// <copyright file="ExternalMovieCollectionController.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Controllers.API
{
    using System.Web.Http;
    using Web.Models.Dependencies;
    using Web.Models.ExternalMovies;

    /// <summary>
    /// API controller class for import movie collections
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class ExternalMovieCollectionController : ApiController
    {
        #region Members

        /// <summary>
        /// The dependencies
        /// </summary>
        private ExternalMovieControllerDependencies _dependencies;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ExternalMovieCollectionController"/> class.
        /// </summary>
        /// <param name="dependencies">The dependencies.</param>
        public ExternalMovieCollectionController(ExternalMovieControllerDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Get collection details.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The collection result model</returns>
        public ExtendedCollectionResultModel Get(int id)
        {
            var collectionDetails = _dependencies.MovieApi.GetCollection(id);

            var model = _dependencies.ModelFactory.Create(collectionDetails);

            return model;
        }

        #endregion Public Methods
    }
}