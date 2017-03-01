using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ProyectoUniversidad.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MailContacto(string Name,string Mail,string message)
        {
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com",587);
            clienteSmtp.Credentials = new NetworkCredential("testcomunidadit@gmail.com","testcomit2017");
            clienteSmtp.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("testcomunidadit@gmail.com", "Lagarto");
            mail.To.Add("testcomunidadit@gmail.com");
            mail.Subject = "Te contactaron del blog";
            mail.Body = Name + "(" + Mail + ") te dejó este mensaje : " + message;

            clienteSmtp.Send(mail); 
            return View();
        }
    }
}