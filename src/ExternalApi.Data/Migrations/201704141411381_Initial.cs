//-----------------------------------------------------------------------
// <copyright file="201704141411381_Initial.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.Data.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Initial setup for database migration
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigration" />
    /// <seealso cref="System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata" />
    public partial class Initial : DbMigration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "ExternalApiData.ExternalSources",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Configuration = c.String(),
                    ConfigurationTimestamp = c.DateTime(nullable: false),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            DropTable("ExternalApiData.ExternalSources");
        }
    }
}