namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            AddColumn("dbo.Players", "TeamId", c => c.Int());
            CreateIndex("dbo.Players", "TeamId");
            AddForeignKey("dbo.Players", "TeamId", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Teams", new[] { "CustomerId" });
            DropColumn("dbo.Players", "TeamId");
            DropTable("dbo.Teams");
        }
    }
}
