//-----------------------------------------------------------------------
// <copyright file="MovieService.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Service
{
    using Library.Domain.Models;
    using Library.Service.Dependencies;
    using Library.Service.Interfaces;

    /// <summary>
    /// Service handler for movie data
    /// </summary>
    public class MovieService : IMovieService
    {
        #region Members

        /// <summary>
        /// The dependencies
        /// </summary>
        private MovieServiceDependencies _dependencies;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="MovieService"/> class.
        /// </summary>
        /// <param name="dependencies">The dependencies.</param>
        public MovieService(MovieServiceDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Import a movie.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <returns>Imported movie ID</returns>
        public int ImportMovie(ImportMovieModel details)
        {
            var importDetails = _dependencies.MovieApi.GetFullMovieDetails(details.ExternalId);

            return 0;
        }

        #endregion Public Methods
    }
}