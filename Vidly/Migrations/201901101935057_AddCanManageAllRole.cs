namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCanManageAllRole : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'388b4d22-3113-47f1-af30-64517314f202', N'CanManageAll')");
        }
        
        public override void Down()
        {
        }
    }
}
