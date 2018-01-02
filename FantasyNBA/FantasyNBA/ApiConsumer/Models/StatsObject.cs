using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class StatsObject
    {
        public string category { get; set; }
        public string abbreviation { get; set; }
        public string text { get; set; }
    }
}