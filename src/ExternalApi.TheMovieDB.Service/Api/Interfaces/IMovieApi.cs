//-----------------------------------------------------------------------
// <copyright file="IMovieApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api.Interfaces
{
    using ExternalApi.TheMovieDB.Domain;

    /// <summary>
    /// Movie API interface
    /// </summary>
    public interface IMovieApi
    {
        /// <summary>
        /// Gets the collection details.
        /// </summary>
        /// <param name="collectionId">The collection identifier.</param>
        /// <returns>The collection details</returns>
        ExtendedCollectionResult GetCollection(int collectionId);

        /// <summary>
        /// Gets the full movie details.
        /// </summary>
        /// <param name="movieId">The movie identifier.</param>
        /// <returns>Full movie details</returns>
        ExtendedMovieResult GetFullMovieDetails(int movieId);

        /// <summary>
        /// Searches the movies.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="page">The page number.</param>
        /// <returns>Search results</returns>
        MovieSearchResult SearchMovies(string query, int page);
    }
}