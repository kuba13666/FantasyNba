namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPlayerScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamPlayers", "PlayerScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamPlayers", "PlayerScore");
        }
    }
}
