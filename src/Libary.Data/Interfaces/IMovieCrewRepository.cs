//-----------------------------------------------------------------------
// <copyright file="IMovieCrewRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Interfaces
{
    using Library.Domain.Entities;
    using SharedLibrary.Interfaces;

    /// <summary>
    /// Movie crew repository interface
    /// </summary>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{Library.Domain.Entities.MovieCrew}" />
    public interface IMovieCrewRepository : IGenericDataRepository<MovieCrew>
    {
    }
}