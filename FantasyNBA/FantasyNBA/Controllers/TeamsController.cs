using FantasyNBA.Models;
using FantasyNBA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FantasyNBA.Controllers
{
    public class TeamsController : Controller
    {

        private ApplicationDbContext _context;

        public TeamsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Teams
        public ActionResult New(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var customerViewModel = new CustomerViewModel()
            {
                Customer = customer,
                Leagues = _context.Leagues.ToList()
            };
            return View(customerViewModel);

        }
    }
}