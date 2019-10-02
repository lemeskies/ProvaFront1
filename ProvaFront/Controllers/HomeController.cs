using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaFront.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //lista que retorna todos os dados e envia a viewbag para usar na view index
            Artista a = new Artista();

            List<all> all = new List<all>();
            all = a.lista().week.period.all;

            ViewBag.lista = all;

            return View();
        }
    }
}