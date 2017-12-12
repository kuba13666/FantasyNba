using GenericRepos.Models;
using GenericRepos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CarCMSWebApi.Controllers
{
    public class EmailController : ApiController
    {
        private EmailService _emailService;


        public EmailController()
        {
            _emailService = new EmailService();
        }
        // GET: api/Email
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Email/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Performances
        [ResponseType(typeof(ContactForm))]
        public IHttpActionResult PostEmail(ContactForm contactForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var message = _emailService.CreateMailMessage(contactForm);
            _emailService.SendEmail(message);

            return Ok();
        }

        // PUT: api/Email/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Email/5
        public void Delete(int id)
        {
        }
    }
}
