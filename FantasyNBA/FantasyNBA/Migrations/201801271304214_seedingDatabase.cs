namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingDatabase : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'410d919c-9758-420a-921e-3ed1a9aa0ae9', N'Admin1@fantasynba.com', 0, N'AKvG/HNYpHZ5wdiAOXwCWlZQ4C3+RTMxmJi+OH5bViWzvrPbuOKvTPn53EioseoJCw==', N'999ce573-60b0-4af2-9478-ec16598aaf73', NULL, 0, 0, NULL, 1, 0, N'Admin1@fantasynba.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'71f5056d-7bd1-46b5-9f33-0f89304141fb', N'Guest1@fantasynba.com', 0, N'AIsjTm1w2c1jsSTkIO8Kv8jgpVxAbudj8xMdHpDjlVsgKg5ZVErf8tY48Ick9x5+Zw==', N'a86bd4a9-9e7f-472a-8e4a-08860f11967c', NULL, 0, 0, NULL, 1, 0, N'Guest1@fantasynba.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'29210bd8-8ecb-454e-aa05-8bd69aa56ef9', N'CanManageLeagues')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'410d919c-9758-420a-921e-3ed1a9aa0ae9', N'29210bd8-8ecb-454e-aa05-8bd69aa56ef9')

");
        }
        
        public override void Down()
        {
        }
    }
}
