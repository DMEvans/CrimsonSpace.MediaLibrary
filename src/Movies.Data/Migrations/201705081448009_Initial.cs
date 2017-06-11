//-----------------------------------------------------------------------
// <copyright file="201705081448009_Initial.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Movies.Data.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Initial migration class
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigration" />
    /// <seealso cref="System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata" />
    public partial class Initial : DbMigration
    {
        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            DropForeignKey("MovieData.MovieGenres", "Genre_Id", "MovieData.Genres");
            DropForeignKey("MovieData.MovieGenres", "Movie_Id", "MovieData.Movies");
            DropIndex("MovieData.MovieGenres", new[] { "Genre_Id" });
            DropIndex("MovieData.MovieGenres", new[] { "Movie_Id" });
            DropTable("MovieData.MovieGenres");
            DropTable("MovieData.Movies");
            DropTable("MovieData.Genres");
        }

        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "MovieData.Genres",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "MovieData.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Budget = c.Double(nullable: false),
                    CollectionId = c.Int(),
                    HomePage = c.String(),
                    ReleaseDate = c.DateTime(nullable: false),
                    Revenue = c.Double(nullable: false),
                    Runtime = c.Int(nullable: false),
                    Tagline = c.String(),
                    Title = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "MovieData.MovieGenres",
                c => new
                {
                    Movie_Id = c.Int(nullable: false),
                    Genre_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Movie_Id, t.Genre_Id })
                .ForeignKey("MovieData.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("MovieData.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Genre_Id);
        }
    }
}