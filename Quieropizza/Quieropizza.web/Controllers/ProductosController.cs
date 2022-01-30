using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quieropizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza Jamón y Queso";
            producto1.Precio = 280;

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza Hut Chesee";
            producto2.Precio = 190;

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza 6 Quesos";
            producto3.Precio = 260;

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Alistas de Pollo";
            producto4.Precio = 120;

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);

            return View(listadeProductos);
        }
    }
}