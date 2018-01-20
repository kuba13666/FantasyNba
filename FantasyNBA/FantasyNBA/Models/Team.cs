using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNBA.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<TeamPlayer> TeamPlayers { get; set; }
        public int CustomerId { get; set; }
        public League League { get; set; }
        public int? Score { get; set; }
    }
}