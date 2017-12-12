using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyNBA.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int LastYear { get; set; }
        public int RookieYear { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BirthDate { get; set; }
        public string ProfileUrl { get; set; }
        public string Status { get; set; }
        public string RealTeam { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
        public int? TeamId { get; set; }
    }
}