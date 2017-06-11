//-----------------------------------------------------------------------
// <copyright file="GenreRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Genre repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.Genre}" />
    /// <seealso cref="Library.Data.Interfaces.IGenreRepository" />
    public class GenreRepository : DisconnectedDataRepository<LibraryContext, Genre>, IGenreRepository
    {
    }
}