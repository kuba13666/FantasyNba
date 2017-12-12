using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNba.ApiConsumer.Models
{
    public class PlayersApi
    {
        public int lastYear { get; set; }
        public int rookieYear { get; set; }
        public string fullName { get; set; }
        public string lastName { get; set; }
        public string FirstName { get; set; }
        public string birthDate { get; set; }
        public string profileUrl { get; set; }
        public string status { get; set; }
        public string team { get; set; }
        public int playerId { get; set; }
    }
}