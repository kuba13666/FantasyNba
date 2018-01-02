using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNBA.Models
{
    public class TeamPlayer
    {
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public int TeamId { get; set; }
    }
}