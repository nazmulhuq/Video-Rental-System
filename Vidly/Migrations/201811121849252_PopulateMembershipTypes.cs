namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            
            AddColumn("dbo.MembershipTypes", "DurationInMonthss", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "DurationInMonth");

            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(4, 300, 12, 20)");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "DurationInMonthss");
        }
    }
}
