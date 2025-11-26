using Microsoft.AspNetCore.Mvc;
using My_Portfolios.Models;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace My_Portfolios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SendMessage(ContactForm model)
        //{
        //    if (!ModelState.IsValid)
        //        return View("Index", model);

        //    MailMessage mail = new MailMessage();
        //    mail.From = new MailAddress("asimasimazam6@gmail.com");
        //    mail.To.Add("asimasimazam6@gmail.com");                          // You will receive the mail
        //    mail.Subject = "New Message From Portfolio Website";
        //    mail.Body = $"Name: {model.Name}\nEmail: {model.Email}\nMessage: {model.Msg}";

        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //    smtp.EnableSsl = true;
        //    smtp.Credentials = new NetworkCredential("asimasimazam6@gmail.com", "130310@R");

        //    smtp.Send(mail);

        //    ViewBag.Success = "Message Sent Successfully ?";
        //    return View("Index");
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
