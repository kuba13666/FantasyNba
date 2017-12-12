using FantasyNBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyNBA.ViewModels
{
    public class PlayerViewModel
    {
        public Player Player { get; set; }
        public List<Customer> Customers { get; set; }
    }
}