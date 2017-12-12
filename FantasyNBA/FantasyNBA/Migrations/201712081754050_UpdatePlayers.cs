namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePlayers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Position_id", "dbo.Positions");
            DropIndex("dbo.Players", new[] { "Position_id" });
            RenameColumn(table: "dbo.Players", name: "Position_id", newName: "PositionId");
            AlterColumn("dbo.Players", "PositionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Players", "PositionId");
            AddForeignKey("dbo.Players", "PositionId", "dbo.Positions", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "PositionId", "dbo.Positions");
            DropIndex("dbo.Players", new[] { "PositionId" });
            AlterColumn("dbo.Players", "PositionId", c => c.Int());
            RenameColumn(table: "dbo.Players", name: "PositionId", newName: "Position_id");
            CreateIndex("dbo.Players", "Position_id");
            AddForeignKey("dbo.Players", "Position_id", "dbo.Positions", "id");
        }
    }
}
