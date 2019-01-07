namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDateOfBirth : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.String());
        }
    }
}
