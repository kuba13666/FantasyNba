using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class Playerstatsentry
    {
        public PlayerShort player { get; set; }
        public Team team { get; set; }
        public Stats stats { get; set; }
    }
}