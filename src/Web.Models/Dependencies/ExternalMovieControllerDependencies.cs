//-----------------------------------------------------------------------
// <copyright file="ExternalMovieControllerDependencies.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Web.Models.Dependencies
{
    using ExternalApi.TheMovieDB.Service.Api.Interfaces;
    using Library.Service.Interfaces;
    using Web.Models.ExternalMovies;

    /// <summary>
    /// Dependency container for external movie controllers
    /// </summary>
    public class ExternalMovieControllerDependencies
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="ExternalMovieControllerDependencies"/> class.
        /// </summary>
        /// <param name="modelFactory">The model factory.</param>
        /// <param name="movieApi">The movie API handler.</param>
        /// <param name="genreApi">The genre API handler.</param>
        /// <param name="personApi">The person API handler.</param>
        /// <param name="movieService">The movie service.</param>
        public ExternalMovieControllerDependencies(MovieImportModelFactory modelFactory, IMovieApi movieApi, IGenreApi genreApi, IPersonApi personApi, IMovieService movieService)
        {
            GenreApi = genreApi;
            ModelFactory = modelFactory;
            MovieApi = movieApi;
            MovieService = movieService;
            PersonApi = personApi;

            ModelFactory.Genres = GenreApi.GetMovieGenres();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the genre API handler.
        /// </summary>
        /// <value>
        /// The genre API handler.
        /// </value>
        public IGenreApi GenreApi { get; private set; }

        /// <summary>
        /// Gets the model factory.
        /// </summary>
        /// <value>
        /// The model factory.
        /// </value>
        public MovieImportModelFactory ModelFactory { get; private set; }

        /// <summary>
        /// Gets the movie API handler.
        /// </summary>
        /// <value>
        /// The movie API handler.
        /// </value>
        public IMovieApi MovieApi { get; private set; }

        /// <summary>
        /// Gets the movie data service.
        /// </summary>
        /// <value>
        /// The movie data service.
        /// </value>
        public IMovieService MovieService { get; private set; }

        /// <summary>
        /// Gets the person API handler.
        /// </summary>
        /// <value>
        /// The person API handler.
        /// </value>
        public IPersonApi PersonApi { get; private set; }

        #endregion Properties
    }
}