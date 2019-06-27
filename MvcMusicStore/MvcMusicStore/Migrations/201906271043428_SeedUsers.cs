namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7859ad40-8e41-4e94-8824-550554f07a6a', N'guest@vidly.com', 0, N'ALRwUxn6qfAd3+h2KgxZrCs5y9nHJKm85uq71ygpQ3sm0vfkep5DDsWIjo8hC7Osjg==', N'cfaab897-c6cf-4903-81e0-f351036edbda', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c7037837-d159-448d-967a-1461d875a798', N'admin@vidly.com', 0, N'AEAk45SeKQK1GPCjmNMUBCXHF0FHwmMnxWPqSC9ClKwJEGmpovCo3JaLW3Bs0+ADIw==', N'2698ad10-8a0a-4e22-af65-3983e09a3dc0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4d31f8b3-19a4-4961-994e-41dbc7310fbc', N'Admin')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c7037837-d159-448d-967a-1461d875a798', N'4d31f8b3-19a4-4961-994e-41dbc7310fbc')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
