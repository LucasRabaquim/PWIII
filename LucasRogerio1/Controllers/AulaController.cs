using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeLucasRogerio1.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aluno()
        {
            ViewBag.msg = "Os melhores alunos são aqueles que estudam mais!";
            return View();
        }

        public ActionResult RedirectGoogle()
        {
            return Redirect("https://www.google.com.br/");
        }
    }
}