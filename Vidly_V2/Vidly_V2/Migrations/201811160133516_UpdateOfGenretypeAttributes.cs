namespace Vidly_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOfGenretypeAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GenreTypes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GenreTypes", "Name", c => c.String(nullable: false));
        }
    }
}
