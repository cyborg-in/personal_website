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

        public ContentResult Content()
        {
            return Content("<div><h1>This is the header</h1><p>This is a paragraph</p></div>");
        }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create ([Bind("FirstName, LastName, Email, Comments")] Contact contact)
        // {

        // }


        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task SendEmail (Contact contact)
        // {
        //     SmtpClient client = new SmtpClient();
        //     client.EnableSsl = true;
        //     client.Port = 587;
        //     client.Credentials = new NetworkCredential("mcataloe@gmail.com", "Superbad@062909");

        //     // client.Send("mcataloe@gmail.com", "personnel.rso@gmail.com", "Subject here", "Body of text here");

        //     MailMessage mail = new MailMessage();
        //     mail.From = new MailAddress("mcataloe@gmail.com", "Matthew Cataldi");
        //     mail.To.Add(new MailAddress("personnel.rso@gmail.com", "Personnel Manager (RSO)"));
        //     mail.CC.Add(new MailAddress("renovostrings@gmail.com", "Renovo String Orchestra"));
        //     mail.Subject = "Here is the subject of the email";
        //     mail.Body = "<h1>Here is the header</h1><p>Here is the body of the email.</p>";
        //     mail.IsBodyHtml = true;

        //     client.Send(mail);

        // }

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
