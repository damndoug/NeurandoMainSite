using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Neurando.ViewModels;

namespace Neurando.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.IsHome = true;

            return View();
        }

        [HttpPost]
        [RouteAttribute("")]
        public async Task<IActionResult> SendMail(SendEmailViewModel sendEmailModel) 
        {
            if (!ModelState.IsValid)
            {
                
                return View("Index", sendEmailModel);      
            }
            
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("credentials.json")
                .Build();
            
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(sendEmailModel.UserName, sendEmailModel.UserMail));
            emailMessage.To.Add(new MailboxAddress("Neurando Team", "admin@neurando.com"));
            emailMessage.Body = new TextPart("plain") { Text = sendEmailModel.UserMessage };
            
            using(var client = new SmtpClient())
            {
                client.LocalDomain = "smtp.gmail.com";
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls).ConfigureAwait(false);
                client.Authenticate(config["userName"], config["userPassword"]);
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }

            return View("MailSent", sendEmailModel);
        }

        public IActionResult Status()
        {
            return Ok(new {douglas = "machão"});
        }
    }
}
