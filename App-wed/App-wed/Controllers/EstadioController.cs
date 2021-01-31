using App_wed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_wed.Controllers
{
    public class EstadioController : Controller
    {
        // GET: Estadio
        public ActionResult Index()
        {
            var estadio = new EstadioModel();
            estadio.Id = 1;
            estadio.Descripcion = "Tour del Estadio";


            return View(estadio);
        }
    }
}