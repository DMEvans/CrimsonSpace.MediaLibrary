//-----------------------------------------------------------------------
// <copyright file="IExternalSourceRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.Data.Interfaces
{
    using ExternalApi.Domain;
    using SharedLibrary.Interfaces;

    /// <summary>
    /// External source repository interface
    /// </summary>
    /// <seealso cref="SharedLibrary.Interfaces.IGenericDataRepository{ExternalApi.Domain.ExternalSource}" />
    public interface IExternalSourceRepository : IGenericDataRepository<ExternalSource>
    {
    }
}