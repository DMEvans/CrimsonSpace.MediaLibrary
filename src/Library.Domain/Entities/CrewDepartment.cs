//-----------------------------------------------------------------------
// <copyright file="CrewDepartment.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Domain.Entities
{
    using SharedLibrary.Objects;
    using System.Collections;

    /// <summary>
    /// Crew department container class
    /// </summary>
    /// <seealso cref="SharedLibrary.Objects.BaseEntity" />
    public class CrewDepartment : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}