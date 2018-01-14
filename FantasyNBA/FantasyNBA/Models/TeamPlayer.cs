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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Pts { get; set; }
        public int Reb { get; set; }
        public int Ast { get; set; }
        public int Stl { get; set; }
        public int Blk { get; set; }
        public int PlayerScore { get; set; }
    }
}