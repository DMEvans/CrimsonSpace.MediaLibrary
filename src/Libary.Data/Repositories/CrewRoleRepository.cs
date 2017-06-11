//-----------------------------------------------------------------------
// <copyright file="CrewRoleRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Crew role repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.CrewRole}" />
    /// <seealso cref="Library.Data.Interfaces.ICrewRoleRepository" />
    public class CrewRoleRepository : DisconnectedDataRepository<LibraryContext, CrewRole>, ICrewRoleRepository
    {
    }
}