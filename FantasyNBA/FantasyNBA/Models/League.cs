using System.Collections.Generic;

namespace FantasyNBA.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
    }
}