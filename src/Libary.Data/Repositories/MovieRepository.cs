//-----------------------------------------------------------------------
// <copyright file="MovieRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Movie repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.Movie}" />
    /// <seealso cref="IExternalSourceRepository" />
    public class MovieRepository : DisconnectedDataRepository<LibraryContext, Movie>, IMovieRepository
    {
    }
}