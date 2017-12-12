using FantasyNBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using FantasyNBA.ViewModels;

namespace FantasyNBA.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult GetCustomers()
        {

            return View();
        }
        public ActionResult CustomerDetails(int id)
        {
            var customer = _context.Customers.Include(m=>m.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerViewModel()
            {
                MembershipTypes = membershipTypes,
            };
            return View("CustomerForm",viewModel);
        }
        [HttpPost]
        public ActionResult SaveCustomer(CustomerViewModel viewModel)
        {
            Customer customer = viewModel.Customer;
            if (customer.Id==0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                _context.Entry(customer).State = EntityState.Modified;
            }


            _context.SaveChanges();
            return RedirectToAction("GetCustomers", "Customers");
        }
      
        public ActionResult EditCustomer(int id)
        {
            Customer customer = _context.Customers.SingleOrDefault(c=>c.Id==id);
            var membershipTypes = _context.MembershipTypes.ToList();

            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = new CustomerViewModel
            {
                MembershipTypes = membershipTypes,
                Customer = customer
            };
            _context.SaveChanges();
            return View("CustomerForm", viewModel);
        }
    }
}