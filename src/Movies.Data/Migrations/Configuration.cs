//-----------------------------------------------------------------------
// <copyright file="Configuration.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Movies.Data.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Migration configuration class
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigrationsConfiguration{Movies.Data.MoviesContext}" />
    internal sealed class Configuration : DbMigrationsConfiguration<Movies.Data.MoviesContext>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        /// Runs after upgrading to the latest migration to allow seed data to be updated.
        /// </summary>
        /// <param name="context">Context to be used for updating seed data.</param>
        /// <remarks>
        /// Note that the database may already contain seed data when this method runs. This means that
        /// implementations of this method must check whether or not seed data is present and/or up-to-date
        /// and then only make changes if necessary and in a non-destructive way. The
        /// <see cref="M:System.Data.Entity.Migrations.DbSetMigrationsExtensions.AddOrUpdate``1(System.Data.Entity.IDbSet{``0},``0[])" />
        /// can be used to help with this, but for seeding large amounts of data it may be necessary to do less
        /// granular checks if performance is an issue.
        /// If the <see cref="T:System.Data.Entity.MigrateDatabaseToLatestVersion`2" /> database
        /// initializer is being used, then this method will be called each time that the initializer runs.
        /// If one of the <see cref="T:System.Data.Entity.DropCreateDatabaseAlways`1" />, <see cref="T:System.Data.Entity.DropCreateDatabaseIfModelChanges`1" />,
        /// or <see cref="T:System.Data.Entity.CreateDatabaseIfNotExists`1" /> initializers is being used, then this method will not be
        /// called and the Seed method defined in the initializer should be used instead.
        /// </remarks>
        protected override void Seed(Movies.Data.MoviesContext context)
        {
        }
    }
}