namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDobToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "dateOfBirth", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "dateOfBirth");
        }
    }
}
