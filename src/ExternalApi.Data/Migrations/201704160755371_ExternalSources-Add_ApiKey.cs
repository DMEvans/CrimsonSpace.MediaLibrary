//-----------------------------------------------------------------------
// <copyright file="201704160755371_ExternalSources-Add_ApiKey.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace ExternalApi.Data.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Migration class to add the API key column to the external sources table
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigration" />
    /// <seealso cref="System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata" />
    public partial class ExternalSourcesAdd_ApiKey : DbMigration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            AddColumn("ExternalApiData.ExternalSources", "ApiKey", c => c.String());
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            DropColumn("ExternalApiData.ExternalSources", "ApiKey");
        }
    }
}