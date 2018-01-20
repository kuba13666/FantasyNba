namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamScoreProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Score", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Score");
        }
    }
}
