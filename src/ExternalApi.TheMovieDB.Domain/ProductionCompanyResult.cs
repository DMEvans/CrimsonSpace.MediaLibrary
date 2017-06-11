//-----------------------------------------------------------------------
// <copyright file="ProductionCompanyResult.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.TheMovieDB.Domain
{
    using System;
    using Interfaces;

    /// <summary>
    /// Container object for a production company result
    /// </summary>
    /// <seealso cref="ExternalApi.TheMovieDB.Domain.Interfaces.IBasicObject" />
    public class ProductionCompanyResult : IBasicObject
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(IBasicObject other)
        {
            return other.Id == Id;
        }
    }
}