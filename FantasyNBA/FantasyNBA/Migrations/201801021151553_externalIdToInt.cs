namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class externalIdToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TeamPlayers", "ExternalId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeamPlayers", "ExternalId", c => c.String());
        }
    }
}
