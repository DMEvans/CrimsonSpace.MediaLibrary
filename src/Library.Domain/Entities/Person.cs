//-----------------------------------------------------------------------
// <copyright file="Person.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Domain.Entities
{
    using SharedLibrary.Objects;
    using System.Collections.Generic;

    /// <summary>
    /// Person container class
    /// </summary>
    public class Person : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the crew credits.
        /// </summary>
        /// <value>
        /// The crew credits.
        /// </value>
        public virtual ICollection<MovieCrew> CrewCredits { get; set; }
    }
}