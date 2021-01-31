using App_wed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_wed.Controllers
{
    public class MyEquipoController : Controller
    {
        // GET: MyEquipo
        public ActionResult Index()
        {
            var myequipo = new MyEquipoModel();
            myequipo.Id = 1;
            myequipo.Descripcion = "Plantilla";

            return View(myequipo);
        }
    }
}