//-----------------------------------------------------------------------
// <copyright file="ICrewDepartmentRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Interfaces
{
    using Library.Domain.Entities;
    using SharedLibrary.Interfaces;

    /// <summary>
    /// Crew department repository interface
    /// </summary>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{Library.Domain.Entities.CrewDepartment}" />
    public interface ICrewDepartmentRepository : IGenericDataRepository<CrewDepartment>
    {
    }
}