//-----------------------------------------------------------------------
// <copyright file="LibraryContext.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data
{
    using Library.Domain.Entities;
    using System.Data.Entity;

    /// <summary>
    /// Library database context
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class LibraryContext : DbContext
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="LibraryContext"/> class.
        /// </summary>
        public LibraryContext() : base("name=MediaLibrary")
        {
        }

        /// <summary>
        /// Gets or sets the crew departments.
        /// </summary>
        /// <value>
        /// The crew departments.
        /// </value>
        public DbSet<CrewDepartment> CrewDepartments { get; set; }

        /// <summary>
        /// Gets or sets the crew roles.
        /// </summary>
        /// <value>
        /// The crew roles.
        /// </value>
        public DbSet<CrewRole> CrewRoles { get; set; }

        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        /// <value>
        /// The movies.
        /// </value>
        public DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// Gets or sets the genres.
        /// </summary>
        /// <value>
        /// The genres.
        /// </value>
        public DbSet<Genre> Genres { get; set; }

        /// <summary>
        /// Gets or sets the movie genre links.
        /// </summary>
        /// <value>
        /// The movie genre links.
        /// </value>
        public DbSet<MovieGenreLink> MovieGenreLinks { get; set; }

        /// <summary>
        /// Gets or sets the people.
        /// </summary>
        /// <value>
        /// The people.
        /// </value>
        public DbSet<Person> People { get; set; }

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
            modelBuilder.HasDefaultSchema("Library");

            modelBuilder.Entity<MovieGenreLink>()
                .HasRequired<Movie>(x => x.Movie)
                .WithMany(x => x.GenreLinks)
                .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<MovieGenreLink>()
                .HasRequired<Genre>(x => x.Genre)
                .WithMany()
                .HasForeignKey(x => x.GenreId);

            modelBuilder.Entity<MovieCrew>()
                .HasRequired<CrewDepartment>(x => x.Department)
                .WithMany()
                .HasForeignKey(x => x.DepartmentId);

            modelBuilder.Entity<MovieCrew>()
                .HasRequired<CrewRole>(x => x.Role)
                .WithMany()
                .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<MovieCrew>()
                .HasRequired<Movie>(x => x.Movie)
                .WithMany()
                .HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<MovieCrew>()
                .HasRequired<Person>(x => x.Person)
                .WithMany()
                .HasForeignKey(x => x.PersonId);

            base.OnModelCreating(modelBuilder);
        }
    }
}