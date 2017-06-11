//-----------------------------------------------------------------------
// <copyright file="IPersonApi.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Service.Api.Interfaces
{
    using ExternalApi.TheMovieDB.Domain;

    /// <summary>
    /// Person API interface
    /// </summary>
    public interface IPersonApi
    {
        /// <summary>
        /// Gets the full person details.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Person details</returns>
        ExtendedPersonResult GetFullPersonDetails(int personId);
    }
}