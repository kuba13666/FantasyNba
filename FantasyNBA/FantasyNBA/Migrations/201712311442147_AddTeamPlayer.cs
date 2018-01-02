namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamPlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamPlayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExternalId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            DropTable("dbo.Players");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        InternalId = c.Int(nullable: false, identity: true),
                        PlayerApiID = c.String(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        JerseyNumber = c.String(),
                        Position = c.String(),
                        Height = c.String(),
                        Weight = c.String(),
                        BirthDate = c.String(),
                        Age = c.String(),
                        BirthCity = c.String(),
                        BirthCountry = c.String(),
                        IsRookie = c.String(),
                        officialImageSrc = c.String(),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.InternalId);
            
            DropForeignKey("dbo.TeamPlayers", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamPlayers", new[] { "TeamId" });
            DropTable("dbo.TeamPlayers");
        }
    }
}
