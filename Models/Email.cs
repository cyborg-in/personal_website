using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PersonalWebsite.Models
{
    public class SendEmail
    {
        private static readonly IConfiguration _configuration = new ConfigurationBuilder()
                                                    .SetBasePath(Directory.GetCurrentDirectory())
                                                    .AddJsonFile("appsettings.json")
                                                    .Build();
        
        private MailAddress _fromAddress = new MailAddress(_configuration.GetValue<string>("EmailSettings:Username"), _configuration.GetValue<string>("EmailSettings:DisplayName"));
        
        private async Task Email(IEnumerable<MailAddress> toAddresses, string subject, string body)
        {
            NetworkCredential credential = new NetworkCredential();
                credential.UserName = _configuration.GetValue<string>("EmailSettings:Username");
                credential.Password = _configuration.GetValue<string>("EmailSettings:Password");           

            SmtpClient client = new SmtpClient();
                client.EnableSsl = _configuration.GetValue<bool>("EmailSettings:SSL");
                client.Port = _configuration.GetValue<int>("EmailSettings:Port");
                client.Credentials = credential;
                client.Host = _configuration.GetValue<string>("EmailSettings:SMTP");

            MailMessage mail = new MailMessage();
                mail.From = _fromAddress;
                
                foreach (var address in toAddresses)
                {
                    mail.To.Add(address);
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

            await client.SendMailAsync(mail);
        }
    }
}