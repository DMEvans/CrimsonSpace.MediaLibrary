//-----------------------------------------------------------------------
// <copyright file="IMovieService.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Service.Interfaces
{
    using Library.Domain.Models;

    /// <summary>
    /// Movie service interface
    /// </summary>
    public interface IMovieService
    {
        /// <summary>
        /// Import a movie.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <returns>Imported movie ID</returns>
        int ImportMovie(ImportMovieModel details);
    }
}