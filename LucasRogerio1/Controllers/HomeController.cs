using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LucasRogerio1.Controllers
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
            ViewData["Title"] = "Contato";
            return View();
        }

        public ActionResult RedirectAluno()
        {
            TempData["msg"] = "O MVC é um padrão de desenvolvimento muito utilizado no mundo web e é conhecido por 'forçar' o programador a separa as responsabilidades.";
            return RedirectToAction("Aluno","Aula");
        }
    }
}