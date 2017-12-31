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
        public List<int> PlayerIds { get; set; }
        public int CustomerId { get; set; }
    }
}