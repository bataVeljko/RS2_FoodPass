namespace FoodPass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorizationRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'7AB559CA-DFE6-4F46-A0ED-83AF27129602', N'Buyer')
            INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'35290156-431B-44B0-B12C-5D95044B73F0', N'Seller')
            INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'3CA3A429-39FB-4009-B150-7ED2F0947651', N'Support')
            INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'AC83221F-0385-4231-B748-3AF556EE0C85', N'User')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
