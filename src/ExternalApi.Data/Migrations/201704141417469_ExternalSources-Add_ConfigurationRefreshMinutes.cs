//-----------------------------------------------------------------------
// <copyright file="201704141417469_ExternalSources-Add_ConfigurationRefreshMinutes.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.Data.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Migration class for adding the refresh interval to the external sources table
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigration" />
    /// <seealso cref="System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata" />
    public partial class ExternalSourcesAdd_ConfigurationRefreshMinutes : DbMigration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            AddColumn("ExternalApiData.ExternalSources", "ConfigurationRefreshMinutes", c => c.Int(nullable: false));
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            DropColumn("ExternalApiData.ExternalSources", "ConfigurationRefreshMinutes");
        }
    }
}