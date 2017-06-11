//-----------------------------------------------------------------------
// <copyright file="MovieGenreLinkRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Movie genre link repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.MovieGenreLink}" />
    /// <seealso cref="Library.Data.Interfaces.IMovieGenreLinkRepository" />
    public class MovieGenreLinkRepository : DisconnectedDataRepository<LibraryContext, MovieGenreLink>, IMovieGenreLinkRepository
    {
    }
}