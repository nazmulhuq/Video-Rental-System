namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStockNumberAndAvailablenumber : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET StockNumber = 20, NumberAvailable = 20");
        }
        
        public override void Down()
        {
        }
    }
}
