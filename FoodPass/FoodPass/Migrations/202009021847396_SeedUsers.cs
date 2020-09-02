namespace FoodPass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'09e58706-19fb-40d5-ba91-6b8a178aa61f', N'admin@foodpass.com', 0, N'AANjxQUzVENieDOlzxAQ0uY3/8Zmj07ZKf7qEeyL56BZucjhUc09eM+YaE7LMN581g==', N'37d26077-7c61-4e02-ac93-df675b35421e', NULL, 0, 0, NULL, 1, 0, N'admin@foodpass.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'93e4cba1-b328-4799-b856-c80f7360f5e7', N'Admin')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'09e58706-19fb-40d5-ba91-6b8a178aa61f', N'93e4cba1-b328-4799-b856-c80f7360f5e7')
            ");
        }

        public override void Down()
        {
        }
    }
}
