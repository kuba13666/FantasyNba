namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingLeague : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Teams", "League_Id", c => c.Int());
            CreateIndex("dbo.Teams", "League_Id");
            AddForeignKey("dbo.Teams", "League_Id", "dbo.Leagues", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "League_Id", "dbo.Leagues");
            DropIndex("dbo.Teams", new[] { "League_Id" });
            DropColumn("dbo.Teams", "League_Id");
            DropTable("dbo.Leagues");
        }
    }
}
