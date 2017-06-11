//-----------------------------------------------------------------------
// <copyright file="Genre.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Movies.Domain
{
    using SharedLibrary.Objects;
    using System.Collections.Generic;

    /// <summary>
    /// Genre container class
    /// </summary>
    /// <seealso cref="SharedLibrary.Objects.BaseEntity" />
    public class Genre : BaseEntity
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Genre"/> class.
        /// </summary>
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        /// <value>
        /// The movies.
        /// </value>
        public ICollection<Movie> Movies { get; set; }
    }
}