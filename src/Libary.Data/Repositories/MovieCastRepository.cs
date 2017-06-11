//-----------------------------------------------------------------------
// <copyright file="MovieCastRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Movie cast repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.MovieCast}" />
    /// <seealso cref="Library.Data.Interfaces.IMovieCastRepository" />
    public class MovieCastRepository : DisconnectedDataRepository<LibraryContext, MovieCast>, IMovieCastRepository
    {
    }
}