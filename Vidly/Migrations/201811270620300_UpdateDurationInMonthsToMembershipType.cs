namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDurationInMonthsToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET DurationInMonths = CASE Id WHEN 1 THEN 0 WHEN 2 THEN 1 WHEN 3 THEN 3 WHEN 4 THEN 12 END WHERE Id BETWEEN 1 AND 4");

        }
        
        public override void Down()
        {
        }
    }
}
