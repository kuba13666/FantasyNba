namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gamelog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamPlayers", "FirstName", c => c.String());
            AddColumn("dbo.TeamPlayers", "LastName", c => c.String());
            AddColumn("dbo.TeamPlayers", "Pts", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamPlayers", "Pts");
            DropColumn("dbo.TeamPlayers", "LastName");
            DropColumn("dbo.TeamPlayers", "FirstName");
        }
    }
}
