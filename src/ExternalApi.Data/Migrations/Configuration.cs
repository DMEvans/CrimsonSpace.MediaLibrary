//-----------------------------------------------------------------------
// <copyright file="Configuration.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.Data.Migrations
{
    using ExternalApi.Domain;
    using SharedLibrary.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Migration configuration class
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigrationsConfiguration{ExternalApi.Data.ExternalApiContext}" />
    internal sealed class Configuration : DbMigrationsConfiguration<ExternalApi.Data.ExternalApiContext>
    {
        /// <summary>
        /// The database context
        /// </summary>
        private DbContext _context;

        /// <summary>
        /// Initialises a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
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
        protected override void Seed(ExternalApi.Data.ExternalApiContext context)
        {
            using (_context = new ExternalApiContext())
            {
                AddMissingExternalSources();

                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Adds the missing external sources.
        /// </summary>
        private void AddMissingExternalSources()
        {
            var externalSources = GetAllExternalSources();

            externalSources.ForEach(x => _context.Set<ExternalSource>().AddIfNotExists(x, y => y.Name == x.Name));
        }

        /// <summary>
        /// Gets all external sources.
        /// </summary>
        /// <returns>All external sources</returns>
        private List<ExternalSource> GetAllExternalSources()
        {
            var theMovieDb = new ExternalSource()
            {
                Name = "The Movie Database",
                ApiKey = string.Empty,
                Configuration = string.Empty,
                ConfigurationRefreshMinutes = 1440,
                ConfigurationTimestamp = new DateTime(1900, 01, 01),
                CreatedTimestamp = new DateTime(1900, 01, 01),
                Deleted = false
            };

            return new List<ExternalSource>()
            {
                theMovieDb
            };
        }
    }
}