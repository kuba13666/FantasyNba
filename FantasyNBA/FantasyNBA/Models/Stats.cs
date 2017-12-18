using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class Team
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class Game
    {
        public string id { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public Team awayTeam { get; set; }
        public Team homeTeam { get; set; }
        public string location { get; set; }
    }

    public class Player
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
    }



    public class StatsObject
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }



    public class Stats
    {
        public StatsObject Fg2PtAtt { get; set; }
        public StatsObject Fg2PtAttPerGame { get; set; }
        public StatsObject Fg2PtMade { get; set; }
        public StatsObject Fg2PtMadePerGame { get; set; }
        public StatsObject Fg2PtPct { get; set; }
        public StatsObject Fg3PtAtt { get; set; }
        public StatsObject Fg3PtAttPerGame { get; set; }
        public StatsObject Fg3PtMade { get; set; }
        public StatsObject Fg3PtMadePerGame { get; set; }
        public StatsObject Fg3PtPct { get; set; }
        public StatsObject FgAtt { get; set; }
        public StatsObject FgAttPerGame { get; set; }
        public StatsObject FgMade { get; set; }
        public StatsObject FgMadePerGame { get; set; }
        public StatsObject FgPct { get; set; }
        public StatsObject FtAtt { get; set; }
        public StatsObject FtAttPerGame { get; set; }
        public StatsObject FtMade { get; set; }
        public StatsObject FtMadePerGame { get; set; }
        public StatsObject FtPct { get; set; }
        public StatsObject OffReb { get; set; }
        public StatsObject OffRebPerGame { get; set; }
        public StatsObject DefReb { get; set; }
        public StatsObject DefRebPerGame { get; set; }
        public StatsObject Reb { get; set; }
        public StatsObject RebPerGame { get; set; }
        public StatsObject Ast { get; set; }
        public StatsObject AstPerGame { get; set; }
        public StatsObject Pts { get; set; }
        public StatsObject PtsPerGame { get; set; }
        public StatsObject Tov { get; set; }
        public StatsObject TovPerGame { get; set; }
        public StatsObject Stl { get; set; }
        public StatsObject StlPerGame { get; set; }
        public StatsObject Blk { get; set; }
        public StatsObject BlkPerGame { get; set; }
        public StatsObject BlkAgainst { get; set; }
        public StatsObject BlkAgainstPerGame { get; set; }
        public StatsObject Fouls { get; set; }
        public StatsObject FoulsPerGame { get; set; }
        public StatsObject FoulsDrawn { get; set; }
        public StatsObject FoulsDrawnPerGame { get; set; }
        public StatsObject FoulPers { get; set; }
        public StatsObject FoulPersPerGame { get; set; }
        public StatsObject FoulPersDrawn { get; set; }
        public StatsObject FoulPersDrawnPerGame { get; set; }
        public StatsObject FoulTech { get; set; }
        public StatsObject FoulTechPerGame { get; set; }
        public StatsObject FoulTechDrawn { get; set; }
        public StatsObject FoulTechDrawnPerGame { get; set; }
        public StatsObject FoulFlag1 { get; set; }
        public StatsObject FoulFlag1PerGame { get; set; }
        public StatsObject FoulFlag1Drawn { get; set; }
        public StatsObject FoulFlag1DrawnPerGame { get; set; }
        public StatsObject FoulFlag2 { get; set; }
        public StatsObject FoulFlag2PerGame { get; set; }
        public StatsObject FoulFlag2Drawn { get; set; }
        public StatsObject FoulFlag2DrawnPerGame { get; set; }
        public StatsObject Ejections { get; set; }
        public StatsObject PlusMinus { get; set; }
        public StatsObject PlusMinusPerGame { get; set; }
        public StatsObject MinSeconds { get; set; }
        public StatsObject MinSecondsPerGame { get; set; }
        public StatsObject GamesStarted { get; set; }
    }

    public class Gamelog
    {
        public Game game { get; set; }
        public Player player { get; set; }
        public Team team { get; set; }
        public Stats stats { get; set; }
    }

    public class Playergamelogs
    {
        public string lastUpdatedOn { get; set; }
        public List<Gamelog> gamelogs { get; set; }
    }

    public class RootObject
    {
        public Playergamelogs playergamelogs { get; set; }
    }
}