namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'815ab31d-643d-45e0-83bb-8e33d5cff776', N'haf@mvcmusicstore.com', 0, N'AFW1+hK3dssplQHRY9NFUeasjqoWF/rwtOazqVegoQqn6gox0pSJEusFmK6qzfdxnA==', N'371ae13b-24a2-4cb2-a4db-22f6dabd15d4', NULL, 0, 0, NULL, 1, 0, N'haf@mvcmusicstore.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3e435764-61bf-4e52-8ba6-b2b2b6a87761', N'admin@mvcmusicstore.com', 0, N'ADhOV+NGVm/yCcyq0T10XmEayBQE3eJS0d0k5XUOOoZQ1i9Z+TTMuqUP/Q3xv9PJig==', N'7c9cf1cb-363f-45b4-89a2-98c301385077', NULL, 0, 0, NULL, 1, 0, N'admin@mvcmusicstore.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4d31f8b3-19a4-4961-994e-41dbc7310fbc', N'Admin')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3e435764-61bf-4e52-8ba6-b2b2b6a87761', N'4d31f8b3-19a4-4961-994e-41dbc7310fbc')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
