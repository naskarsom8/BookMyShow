namespace BookMyShow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedReleaseDateSpelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "ReleeaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ReleeaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
