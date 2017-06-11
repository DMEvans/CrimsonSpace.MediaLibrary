//-----------------------------------------------------------------------
// <copyright file="PersonRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Repositories
{
    using Library.Data.Interfaces;
    using Library.Domain.Entities;
    using SharedLibrary.Data;

    /// <summary>
    /// Person repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{Library.Data.LibraryContext, Library.Domain.Entities.Person}" />
    /// <seealso cref="Library.Data.Interfaces.IPersonRepository" />
    public class PersonRepository : DisconnectedDataRepository<LibraryContext, Person>, IPersonRepository
    {
    }
}