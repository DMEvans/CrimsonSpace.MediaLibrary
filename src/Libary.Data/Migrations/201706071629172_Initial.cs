//-----------------------------------------------------------------------
// <copyright file="201706071629172_Initial.cs" company="Crimson Space Media">
//    Copyright Crimson Space Media
// </copyright>
//-----------------------------------------------------------------------

namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Database migration for the initial build
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
                "Library.CrewDepartments",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "Library.CrewRoles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "Library.Genres",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "Library.MovieGenreLinks",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MovieId = c.Int(nullable: false),
                    GenreId = c.Int(nullable: false),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Library.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("Library.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.GenreId);

            CreateTable(
                "Library.Movies",
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
                "Library.MovieCrews",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MovieId = c.Int(nullable: false),
                    PersonId = c.Int(nullable: false),
                    DepartmentId = c.Int(nullable: false),
                    RoleId = c.Int(nullable: false),
                    Deleted = c.Boolean(nullable: false),
                    CreatedTimestamp = c.DateTime(nullable: false),
                    Person_Id = c.Int(),
                    Movie_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Library.CrewDepartments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("Library.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("Library.People", t => t.Person_Id)
                .ForeignKey("Library.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("Library.CrewRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("Library.Movies", t => t.Movie_Id)
                .Index(t => t.MovieId)
                .Index(t => t.PersonId)
                .Index(t => t.DepartmentId)
                .Index(t => t.RoleId)
                .Index(t => t.Person_Id)
                .Index(t => t.Movie_Id);

            CreateTable(
                "Library.People",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
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
            DropForeignKey("Library.MovieGenreLinks", "MovieId", "Library.Movies");
            DropForeignKey("Library.MovieCrews", "Movie_Id", "Library.Movies");
            DropForeignKey("Library.MovieCrews", "RoleId", "Library.CrewRoles");
            DropForeignKey("Library.MovieCrews", "PersonId", "Library.People");
            DropForeignKey("Library.MovieCrews", "Person_Id", "Library.People");
            DropForeignKey("Library.MovieCrews", "MovieId", "Library.Movies");
            DropForeignKey("Library.MovieCrews", "DepartmentId", "Library.CrewDepartments");
            DropForeignKey("Library.MovieGenreLinks", "GenreId", "Library.Genres");
            DropIndex("Library.MovieCrews", new[] { "Movie_Id" });
            DropIndex("Library.MovieCrews", new[] { "Person_Id" });
            DropIndex("Library.MovieCrews", new[] { "RoleId" });
            DropIndex("Library.MovieCrews", new[] { "DepartmentId" });
            DropIndex("Library.MovieCrews", new[] { "PersonId" });
            DropIndex("Library.MovieCrews", new[] { "MovieId" });
            DropIndex("Library.MovieGenreLinks", new[] { "GenreId" });
            DropIndex("Library.MovieGenreLinks", new[] { "MovieId" });
            DropTable("Library.People");
            DropTable("Library.MovieCrews");
            DropTable("Library.Movies");
            DropTable("Library.MovieGenreLinks");
            DropTable("Library.Genres");
            DropTable("Library.CrewRoles");
            DropTable("Library.CrewDepartments");
        }
    }
}