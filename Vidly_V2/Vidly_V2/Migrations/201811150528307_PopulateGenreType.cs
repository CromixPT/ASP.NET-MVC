namespace Vidly_V2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreType:DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Comedy')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Action')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Family')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Romance')");
            Sql("INSERT INTO GenreTypes (Name) VALUES ('Thriller')");

        }


        public override void Down()
        {
        }
    }
}
