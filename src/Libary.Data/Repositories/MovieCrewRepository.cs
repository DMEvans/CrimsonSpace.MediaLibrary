//-----------------------------------------------------------------------
// <copyright file="MovieCrewRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Movie crew repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.MovieCrew}" />
    /// <seealso cref="Library.Data.Interfaces.IMovieCrewRepository" />
    public class MovieCrewRepository : DisconnectedDataRepository<LibraryContext, MovieCrew>, IMovieCrewRepository
    {
    }
}