//-----------------------------------------------------------------------
// <copyright file="IMovieGenreLinkRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Interfaces
{
    using Library.Domain.Entities;
    using SharedLibrary.Interfaces;

    /// <summary>
    /// Movie genre link container class
    /// </summary>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{Library.Domain.Entities.MovieGenreLink}" />
    public interface IMovieGenreLinkRepository : IGenericDataRepository<MovieGenreLink>
    {
    }
}