using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class Cumulativeplayerstats
    {
        public string lastUpdatedOn { get; set; }
        public IList<Playerstatsentry> playerstatsentry { get; set; }
    }
}