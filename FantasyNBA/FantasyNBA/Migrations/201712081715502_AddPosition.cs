namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPosition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Players", "Position_id", c => c.Int());
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            CreateIndex("dbo.Players", "Position_id");
            AddForeignKey("dbo.Players", "Position_id", "dbo.Positions", "id");
            DropColumn("dbo.Players", "GradeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "GradeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Players", "Position_id", "dbo.Positions");
            DropIndex("dbo.Players", new[] { "Position_id" });
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Players", "Position_id");
            DropTable("dbo.Positions");
        }
    }
}
