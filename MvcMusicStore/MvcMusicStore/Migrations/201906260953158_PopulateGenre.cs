namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Rock', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Classical', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Jazz', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Pop', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Disco', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Latin', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Metal', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Alternative', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Reggae', NULL)
                INSERT INTO [dbo].[Genres] ([Name], [Description]) VALUES (N'Blues', NULL)
            ");
        }
        
        public override void Down()
        {
        }
    }
}
