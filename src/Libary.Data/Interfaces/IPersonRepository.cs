﻿//-----------------------------------------------------------------------
// <copyright file="IPersonRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Interfaces
{
    using Library.Domain.Entities;
    using SharedLibrary.Interfaces;

    /// <summary>
    /// Person repository interface
    /// </summary>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{Library.Domain.Entities.Person}" />
    public interface IPersonRepository : IGenericDataRepository<Person>
    {
    }
}