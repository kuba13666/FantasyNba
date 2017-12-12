namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PositiontoDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Positions (Name) VALUES ('Playmaker')");
            Sql("INSERT INTO Positions (Name) VALUES ('Shooting Guard')");
            Sql("INSERT INTO Positions (Name) VALUES ('Small Forward')");
            Sql("INSERT INTO Positions (Name) VALUES ('Power Forward')");
            Sql("INSERT INTO Positions (Name) VALUES ('Center')");
        }
        
        public override void Down()
        {
        }
    }
}
