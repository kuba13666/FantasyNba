using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class AwayTeam
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class HomeTeam
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
        public AwayTeam awayTeam { get; set; }
        public HomeTeam homeTeam { get; set; }
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

    public class Team
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class Fg2PtAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg2PtAttPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg2PtMade
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg2PtMadePerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg2PtPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3PtAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3PtAttPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3PtMade
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3PtMadePerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fg3PtPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgAttPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMade
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgMadePerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FgPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FtAtt
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FtAttPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FtMade
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FtMadePerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FtPct
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffReb
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class OffRebPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class DefReb
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class DefRebPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Reb
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class RebPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Ast
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class AstPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Pts
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PtsPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Tov
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class TovPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stl
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class StlPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Blk
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BlkPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BlkAgainst
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class BlkAgainstPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Fouls
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulsPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulsDrawn
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulsDrawnPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulPers
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulPersPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulPersDrawn
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulPersDrawnPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulTech
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulTechPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulTechDrawn
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulTechDrawnPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag1
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag1PerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag1Drawn
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag1DrawnPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag2
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag2PerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag2Drawn
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class FoulFlag2DrawnPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Ejections
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlusMinus
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class PlusMinusPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class MinSeconds
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class MinSecondsPerGame
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class GamesStarted
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }

    public class Stats
    {
        public Fg2PtAtt Fg2PtAtt { get; set; }
        public Fg2PtAttPerGame Fg2PtAttPerGame { get; set; }
        public Fg2PtMade Fg2PtMade { get; set; }
        public Fg2PtMadePerGame Fg2PtMadePerGame { get; set; }
        public Fg2PtPct Fg2PtPct { get; set; }
        public Fg3PtAtt Fg3PtAtt { get; set; }
        public Fg3PtAttPerGame Fg3PtAttPerGame { get; set; }
        public Fg3PtMade Fg3PtMade { get; set; }
        public Fg3PtMadePerGame Fg3PtMadePerGame { get; set; }
        public Fg3PtPct Fg3PtPct { get; set; }
        public FgAtt FgAtt { get; set; }
        public FgAttPerGame FgAttPerGame { get; set; }
        public FgMade FgMade { get; set; }
        public FgMadePerGame FgMadePerGame { get; set; }
        public FgPct FgPct { get; set; }
        public FtAtt FtAtt { get; set; }
        public FtAttPerGame FtAttPerGame { get; set; }
        public FtMade FtMade { get; set; }
        public FtMadePerGame FtMadePerGame { get; set; }
        public FtPct FtPct { get; set; }
        public OffReb OffReb { get; set; }
        public OffRebPerGame OffRebPerGame { get; set; }
        public DefReb DefReb { get; set; }
        public DefRebPerGame DefRebPerGame { get; set; }
        public Reb Reb { get; set; }
        public RebPerGame RebPerGame { get; set; }
        public Ast Ast { get; set; }
        public AstPerGame AstPerGame { get; set; }
        public Pts Pts { get; set; }
        public PtsPerGame PtsPerGame { get; set; }
        public Tov Tov { get; set; }
        public TovPerGame TovPerGame { get; set; }
        public Stl Stl { get; set; }
        public StlPerGame StlPerGame { get; set; }
        public Blk Blk { get; set; }
        public BlkPerGame BlkPerGame { get; set; }
        public BlkAgainst BlkAgainst { get; set; }
        public BlkAgainstPerGame BlkAgainstPerGame { get; set; }
        public Fouls Fouls { get; set; }
        public FoulsPerGame FoulsPerGame { get; set; }
        public FoulsDrawn FoulsDrawn { get; set; }
        public FoulsDrawnPerGame FoulsDrawnPerGame { get; set; }
        public FoulPers FoulPers { get; set; }
        public FoulPersPerGame FoulPersPerGame { get; set; }
        public FoulPersDrawn FoulPersDrawn { get; set; }
        public FoulPersDrawnPerGame FoulPersDrawnPerGame { get; set; }
        public FoulTech FoulTech { get; set; }
        public FoulTechPerGame FoulTechPerGame { get; set; }
        public FoulTechDrawn FoulTechDrawn { get; set; }
        public FoulTechDrawnPerGame FoulTechDrawnPerGame { get; set; }
        public FoulFlag1 FoulFlag1 { get; set; }
        public FoulFlag1PerGame FoulFlag1PerGame { get; set; }
        public FoulFlag1Drawn FoulFlag1Drawn { get; set; }
        public FoulFlag1DrawnPerGame FoulFlag1DrawnPerGame { get; set; }
        public FoulFlag2 FoulFlag2 { get; set; }
        public FoulFlag2PerGame FoulFlag2PerGame { get; set; }
        public FoulFlag2Drawn FoulFlag2Drawn { get; set; }
        public FoulFlag2DrawnPerGame FoulFlag2DrawnPerGame { get; set; }
        public Ejections Ejections { get; set; }
        public PlusMinus PlusMinus { get; set; }
        public PlusMinusPerGame PlusMinusPerGame { get; set; }
        public MinSeconds MinSeconds { get; set; }
        public MinSecondsPerGame MinSecondsPerGame { get; set; }
        public GamesStarted GamesStarted { get; set; }
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