using QuieroPizza.BL;
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
            var productosbl = new ProductosBL();
            var listadeproductos = productosbl.obtenerProductos();

            return View(listadeproductos);
        }
    }
}