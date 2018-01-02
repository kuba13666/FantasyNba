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
        public Team awayTeam { get; set; }
        public Team homeTeam { get; set; }
        public string location { get; set; }
    }



    public class Gamelog
    {
        public Game game { get; set; }
        public PlayerShort player { get; set; }
        public Team team { get; set; }
        public Stats stats { get; set; }
    }

    public class Playergamelogs
    {
        public string lastUpdatedOn { get; set; }
        public IList<Gamelog> gamelogs { get; set; }
    }

    public class RootObjectPlayerGameLog
    {
        public Playergamelogs playergamelogs { get; set; }
    }

}