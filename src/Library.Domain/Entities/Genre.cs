﻿//-----------------------------------------------------------------------
// <copyright file="Genre.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Domain.Entities
{
    using SharedLibrary.Objects;

    /// <summary>
    /// Genre container class
    /// </summary>
    /// <seealso cref="SharedLibrary.Objects.BaseEntity" />
    public class Genre : BaseEntity
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