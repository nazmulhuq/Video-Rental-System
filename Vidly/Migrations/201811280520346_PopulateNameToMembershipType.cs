namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = CASE Id WHEN 1 THEN 'Pay as You Go' WHEN 2 THEN 'Monthly' WHEN 3 THEN 'Quarterly' WHEN 4 THEN 'Yearly' END WHERE Id BETWEEN 1 AND 4");
        }
        
        public override void Down()
        {
        }
    }
}
