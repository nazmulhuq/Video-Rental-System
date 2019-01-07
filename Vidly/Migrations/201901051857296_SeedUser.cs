namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6af2f378-41ea-4ccb-a875-0af5b604bc84', N'guest@gmail.com', 0, N'AC4pxQuN95+Ai/M6NoiTyVBPyNWGdJmGQkO/S0V2Bb8gSxaZCRlyQal9MaQvEBuXGQ==', N'2e1d5b4c-18d2-4a86-ae99-e6b767b35e86', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b64100e0-b2ef-4fb6-86ed-55bf9c041b9a', N'admin@vidly.com', 0, N'AJ4RtAGCG7uU52pkv0GW97BmxgIFBkUu0rehC91lJHu94SH+0bKPJ2HaA0l/kS0nMQ==', N'96768e65-1269-4ed5-9519-51133ac3451d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'388b4d22-3113-47f1-af30-64517314f201', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b64100e0-b2ef-4fb6-86ed-55bf9c041b9a', N'388b4d22-3113-47f1-af30-64517314f201')

");
        }
        
        public override void Down()
        {
        }
    }
}
