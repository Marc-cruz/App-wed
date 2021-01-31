using App_wed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_wed.Controllers
{
    public class EntradasController : Controller
    {
        // GET: Entradas
        public ActionResult Index()
        {
            var entrada1 = new EntradasModel();
            entrada1.Id = 1;
            entrada1.Descricion = "VIP";

            var entrada2 = new EntradasModel();
            entrada2.Id = 1;
            entrada2.Descricion = "Palco";

            var entrada3 = new EntradasModel();
            entrada3.Id = 1;
            entrada3.Descricion = "Silla";

            var listadeEntradas = new List<EntradasModel>();
            listadeEntradas.Add(entrada1);
            listadeEntradas.Add(entrada2);
            listadeEntradas.Add(entrada3);

            return View(listadeEntradas);
        }
    }
}