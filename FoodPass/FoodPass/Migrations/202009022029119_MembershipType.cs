namespace FoodPass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Buyers", "MembershipType_Id", c => c.Int());
            CreateIndex("dbo.Buyers", "MembershipType_Id");
            AddForeignKey("dbo.Buyers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buyers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Buyers", new[] { "MembershipType_Id" });
            DropColumn("dbo.Buyers", "MembershipType_Id");
            DropTable("dbo.MembershipTypes");
        }
    }
}
