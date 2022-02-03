using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();



        }
        public List<Producto> obtenerProductos()
        {
            _contexto.Productos.ToList();
            ListadeProductos = _contexto.Productos.ToList();
           

            return _contexto.Productos.ToList();
      }
    }
}
