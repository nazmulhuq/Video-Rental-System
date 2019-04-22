namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNumberAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = StockNumber");
        }
        
        public override void Down()
        {
        }
    }
}
