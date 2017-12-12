
using GenericRepos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace GenericRepos.Service
{
    public class EmailService
    {
        private readonly SmtpClient _smtpClient;

        public EmailService()
        {
            _smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("gym550182@gmail.com", "!QAZ2wsx#EDC")
            };
        }

        public MailMessage CreateMailMessage(ContactForm contactForm)
        {
            var mailMessage = new MailMessage
            {
                Sender = new MailAddress("gym550182@gmail.com"),
                From = new MailAddress("gym550182@gmail.com"),
                To = { contactForm.Email },
                Subject = contactForm.Subject,
                Body = contactForm.Body,
                IsBodyHtml = true
            };

            return mailMessage;
        }

        public void SendEmail(MailMessage mailMessage)
        {
            _smtpClient.Send(mailMessage);
        }
    }
}