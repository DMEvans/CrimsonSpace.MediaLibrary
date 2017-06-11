//-----------------------------------------------------------------------
// <copyright file="IGenreApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api.Interfaces
{
    using System.Collections.Generic;
    using ExternalApi.TheMovieDB.Domain;

    /// <summary>
    /// Genre API interface
    /// </summary>
    public interface IGenreApi
    {
        /// <summary>
        /// Gets the movie genres.
        /// </summary>
        /// <returns>The movie genres</returns>
        IEnumerable<GenreResult> GetMovieGenres();

        /// <summary>
        /// Gets the TV genres.
        /// </summary>
        /// <returns>The TV genres</returns>
        IEnumerable<GenreResult> GetTvGenres();
    }
}