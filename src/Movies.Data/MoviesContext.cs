﻿//-----------------------------------------------------------------------
// <copyright file="MoviesContext.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Movies.Data
{
    using Movies.Domain;
    using System.Data.Entity;

    /// <summary>
    /// Movies database context
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class MoviesContext : DbContext
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="MoviesContext"/> class.
        /// </summary>
        public MoviesContext() : base("name=MediaLibrary")
        {
        }

        /// <summary>
        /// Gets or sets the movie genres.
        /// </summary>
        /// <value>
        /// The movie genres.
        /// </value>
        public DbSet<Genre> MovieGenres { get; set; }

        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        /// <value>
        /// The movies.
        /// </value>
        public DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuilder, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the <see cref="DbModelBuilder" /> and
        /// <see cref="DbContextFactory" /> classes directly..
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MovieData");
            base.OnModelCreating(modelBuilder);
        }
    }
}