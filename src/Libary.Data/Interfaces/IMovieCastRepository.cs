//-----------------------------------------------------------------------
// <copyright file="IMovieCastRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Interfaces
{
    using Library.Domain.Entities;
    using SharedLibrary.Interfaces;

    /// <summary>
    /// Movie cast repository interface
    /// </summary>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{Library.Domain.Entities.MovieCast}" />
    public interface IMovieCastRepository : IGenericDataRepository<MovieCast>
    {
    }
}