namespace FantasyNBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePlayers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Players (LastYear, RookieYear, FullName, LastName, FirstName, Birthdate, ProfileUrl, Status, RealTeam, PositionId  ) VALUES (2017, 2005, 'Marvin Williams', 'Williams', 'Marvin', '20171018T080543.448Z', '', 'Active', 'CHA', 1 )");
            Sql("INSERT INTO Players (LastYear, RookieYear, FullName, LastName, FirstName, Birthdate, ProfileUrl, Status, RealTeam, PositionId  ) VALUES (2015, 20010, 'Michael jackson', 'Jackson', 'Michael', '20171018T080543.448Z', '', 'Active', 'ORL', 2 )");
            Sql("INSERT INTO Players (LastYear, RookieYear, FullName, LastName, FirstName, Birthdate, ProfileUrl, Status, RealTeam, PositionId  ) VALUES (2017, 2005, 'Steph Curry', 'Curry', 'Steph', '20171018T080543.448Z', '', 'InActive', 'GSW', 3 )");
        }
        public override void Down()
        {
        }
    }
}
