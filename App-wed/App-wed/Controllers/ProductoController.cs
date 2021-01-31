using App_wed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_wed.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Entradas";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Área VIP";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Tienda";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Fans";

            var producto5 = new ProductoModel();
            producto5.Id = 5;
            producto5.Descripcion = "Estadio";

            var producto6 = new ProductoModel();
            producto6.Id = 6;
            producto6.Descripcion = "Noticias";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);
            listadeProductos.Add(producto6);

            return View(listadeProductos);
        }
    }
}