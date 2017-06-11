//-----------------------------------------------------------------------
// <copyright file="ExternalSourceRepository.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.Data.Repositories
{
    using ExternalApi.Data.Interfaces;
    using ExternalApi.Domain;
    using SharedLibrary.Data;

    /// <summary>
    /// External source repository
    /// </summary>
    /// <seealso cref="SharedLibrary.Data.DisconnectedDataRepository{ExternalApi.Data.ExternalApiContext, ExternalApi.Domain.ExternalSource}" />
    /// <seealso cref="ExternalApi.Data.Repositories.IExternalSourceRepository" />
    public class ExternalSourceRepository : DisconnectedDataRepository<ExternalApiContext, ExternalSource>, IExternalSourceRepository
    {
    }
}