//-----------------------------------------------------------------------
// <copyright file="CrewDepartmentRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Crew department repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.CrewDepartment}" />
    /// <seealso cref="Library.Data.Interfaces.ICrewDepartmentRepository" />
    public class CrewDepartmentRepository : DisconnectedDataRepository<LibraryContext, CrewDepartment>, ICrewDepartmentRepository
    {
    }
}