namespace BookMyShow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMembershipTypeDescriptionValues : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Description = 'Pay as You Go' where Id = 1");
            Sql("Update MembershipTypes set Description = 'Monthly' where Id = 2");
            Sql("Update MembershipTypes set Description = 'Quarterly' where Id = 3");
            Sql("Update MembershipTypes set Description = 'Annual' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
