using FantasyNBA.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FantasyNBA.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //Get /api/customers
        public IHttpActionResult GetCustomers()
        {
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = _context.Users.FirstOrDefault(x => x.Id == currentUserId);
            var customers = _context.Customers.Where(c=>c.User.Email==currentUser.Email)
                .Include(t => t.Team)
                .Include(m=>m.MembershipType)
                .ToList();

            return Ok(customers);
        }
        //Get /api/customers/1
        public IHttpActionResult GetCustomersTeams(int id)
        {
            var teams = _context.Teams.Where(x => x.CustomerId == id).ToList();


            return Ok(teams);
        }

        //Post /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customer);
        }

        //Put /api/customers/1
        [HttpPut]
        public void EditCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            if (customer==null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //Delete /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

    }
}
