namespace BookMyShow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMembershipTypeDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Description", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Description");
        }
    }
}
