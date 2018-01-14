namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingStatsToPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamPlayers", "Reb", c => c.Int(nullable: false));
            AddColumn("dbo.TeamPlayers", "Ast", c => c.Int(nullable: false));
            AddColumn("dbo.TeamPlayers", "Stl", c => c.Int(nullable: false));
            AddColumn("dbo.TeamPlayers", "Blk", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamPlayers", "Blk");
            DropColumn("dbo.TeamPlayers", "Stl");
            DropColumn("dbo.TeamPlayers", "Ast");
            DropColumn("dbo.TeamPlayers", "Reb");
        }
    }
}
