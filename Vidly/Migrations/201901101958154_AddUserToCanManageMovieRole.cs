namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToCanManageMovieRole : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6f3ad039-56ac-4daf-8293-b5a94e05ad0d', N'388b4d22-3113-47f1-af30-64517314f202')");
        }
        
        public override void Down()
        {
        }
    }
}
