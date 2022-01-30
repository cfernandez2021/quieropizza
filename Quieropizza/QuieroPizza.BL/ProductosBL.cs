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

        public ProductosBL()
        {
            _contexto = new Contexto();
        



        }
        public List<Producto> obtenerProductos()
        {
            _contexto.Productos.ToList();

           

            return _contexto.Productos.ToList();
      }
    }
}
