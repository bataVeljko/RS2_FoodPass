namespace FoodPass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserShopIds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Buyers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Buyers", new[] { "MembershipType_Id" });
            AddColumn("dbo.Sellers", "ShopId", c => c.Int(nullable: false));
            AddColumn("dbo.Supports", "ShopId", c => c.Int(nullable: false));
            DropColumn("dbo.Buyers", "MembershipType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buyers", "MembershipType_Id", c => c.Int());
            DropColumn("dbo.Supports", "ShopId");
            DropColumn("dbo.Sellers", "ShopId");
            CreateIndex("dbo.Buyers", "MembershipType_Id");
            AddForeignKey("dbo.Buyers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
