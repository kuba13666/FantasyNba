using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class Stats
    {
        public int PlayerID { get; set; }
        public object LeagueID { get; set; }
        public string Season { get; set; }
        public string SeasonType { get; set; }
        public object DateFrom { get; set; }
        public object DateTo { get; set; }
        public string name { get; set; }
        public List<string> headers { get; set; }
        public List<List<object>> rowSet { get; set; }
        public string resource { get; set; }
    }
}