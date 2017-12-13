using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNBA.Models
{
    public class CustomerDTO
    {
        public Customer Customer { get; set; }
        public List<Team> Teams { get; set; }
    }
}