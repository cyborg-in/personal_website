using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PersonalWebsite.Data;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(WebsiteContext context) : base(context) { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About Page";

            return View();
        }

        public async Task<IActionResult> Stacks()
        {
            ViewData["Message"] = "Stacks Page";
            var stacks = await _context.Skills.ToListAsync();

            return View(stacks);
        }

        public IActionResult Projects()
        {
            ViewData["Message"] = "Projects Page";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public ContentResult Content(string firstName, string lastName, string email, string comments)
        {
            return Content($"<div><h1>{ firstName } { lastName }</h1><h2> { email }</h2><p>{ comments }</p></div>");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Create ([Bind("FirstName, LastName, Email, Comments")] Contact contact)
        {
            

            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            SendEmail(contact);
            RedirectToAction("Contact", "Home");
        }

        private async Task SendEmail (Contact contact)
        {
            NetworkCredential credential = new NetworkCredential();
            credential.Password = Directory.

            SmtpClient client = new SmtpClient();
                client.EnableSsl = true;
                client.Port = 587;
                client.Credentials = new NetworkCredential("mcataloe@gmail.com", "");

            MailMessage mail = new MailMessage();
                mail.From = new MailAddress("mcataloe@gmail.com", "Matthew Cataldi");
                mail.To.Add(new MailAddress(contact.Email, contact.FirstName + " " + contact.LastName));
                mail.Subject = "Thanks for your email!";
                mail.Body = $"<h1>Thanks for your email!</h1><p>We'll get back to you as soon as possible.  In the meantime, we just want to make sure we have your information correct.</p><address>{ contact.FirstName } { contact.LastName }<br />{ contact.Email }<br />{ contact.Comments }</address>";
                mail.IsBodyHtml = true;

            await client.SendMailAsync(mail);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public enum Stuff 
    {
        [Display(Name = "United States of America")]
        USA = 1,

        [Display(Name = "United Mexican States")]
        Mexico,
        Canada
    }
}
