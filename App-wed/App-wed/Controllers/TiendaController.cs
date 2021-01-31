using App_wed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_wed.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            var tienda1 = new TiendaModel();
            tienda1.Id = 1;
            tienda1.Descripcion = "Hombre";

            var tienda2 = new TiendaModel();
            tienda2.Id = 2;
            tienda2.Descripcion = "Mujer";

            var tienda3 = new TiendaModel();
            tienda3.Id = 3;
            tienda3.Descripcion = "Niño";

            var tienda4 = new TiendaModel();
            tienda4.Id = 4;
            tienda4.Descripcion = "Niña";

            var tienda5 = new TiendaModel();
            tienda5.Id = 5;
            tienda5.Descripcion = "Tarjetas de Regalo";

            var listadelaTienda = new List<TiendaModel>();
            listadelaTienda.Add(tienda1);
            listadelaTienda.Add(tienda2);
            listadelaTienda.Add(tienda3);
            listadelaTienda.Add(tienda4);
            listadelaTienda.Add(tienda5);

            return View(listadelaTienda);
        }
    }
}