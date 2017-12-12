using FantasyNBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNBA.ViewModels
{
    public class CustomerViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}