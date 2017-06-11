//-----------------------------------------------------------------------
// <copyright file="ICrewRoleRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Interfaces
{
    using Library.Domain.Entities;
    using SharedLibrary.Interfaces;

    /// <summary>
    /// Crew role repository interface
    /// </summary>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{Library.Domain.Entities.CrewRole}" />
    public interface ICrewRoleRepository : IGenericDataRepository<CrewRole>
    {
    }
}