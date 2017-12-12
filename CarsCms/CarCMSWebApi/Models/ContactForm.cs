using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GenericRepos.Models
{
    public class ContactForm
    {

        [EmailAddress]
        public string Email { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

    }
}