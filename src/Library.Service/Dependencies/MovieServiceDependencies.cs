//-----------------------------------------------------------------------
// <copyright file="MovieServiceDependencies.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Service.Dependencies
{
    using ExternalApi.TheMovieDB.Service.Api;
    using Library.Data.Interfaces;

    /// <summary>
    /// Dependency container for the movie data service
    /// </summary>
    public class MovieServiceDependencies
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="MovieServiceDependencies" /> class.
        /// </summary>
        /// <param name="movieRepository">The movie repository.</param>
        /// <param name="genreRepository">The genre repository.</param>
        /// <param name="genreLinkRepository">The genre link repository.</param>
        /// <param name="movieApi">The movie API.</param>
        public MovieServiceDependencies(IMovieRepository movieRepository, IGenreRepository genreRepository, IMovieGenreLinkRepository genreLinkRepository, MovieApi movieApi)
        {
            MovieRepository = movieRepository;
            GenreRepository = genreRepository;
            GenreLinkRepository = genreLinkRepository;
            MovieApi = movieApi;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the genre link repository.
        /// </summary>
        /// <value>
        /// The genre link repository.
        /// </value>
        public IMovieGenreLinkRepository GenreLinkRepository { get; private set; }

        /// <summary>
        /// Gets the genre repository.
        /// </summary>
        /// <value>
        /// The genre repository.
        /// </value>
        public IGenreRepository GenreRepository { get; private set; }

        /// <summary>
        /// Gets the movie API handler.
        /// </summary>
        /// <value>
        /// The movie API handler.
        /// </value>
        public MovieApi MovieApi { get; private set; }

        /// <summary>
        /// Gets the movie repository.
        /// </summary>
        /// <value>
        /// The movie repository.
        /// </value>
        public IMovieRepository MovieRepository { get; private set; }

        #endregion Properties
    }
}