//-----------------------------------------------------------------------
// <copyright file="IBasicObject.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain.Interfaces
{
    using System;

    /// <summary>
    /// Interface describing a basic object with an ID and a Name
    /// </summary>
    public interface IBasicObject : IEquatable<IBasicObject>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }
    }
}