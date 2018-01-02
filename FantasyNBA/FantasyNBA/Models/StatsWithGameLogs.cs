using FantasyNba.ApiConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNBA.Models
{
    public class StatsWithGameLogs
    {
        public Playerstatsentry statsEntry { get; set; }
        public long ptsPerGame { get; set; }
        public long rebPerGame { get; set; }
        public long astPerGame { get; set; }
        public long stlPerGame { get; set; }
        public long blkPerGame { get; set; }
    }
}