﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        public List<Producto> obtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza Jamón y Queso";
            producto1.Precio = 280;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza Hut Chesee";
            producto2.Precio = 190;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza 6 Quesos";
            producto3.Precio = 260;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Alistas de Pollo";
            producto4.Precio = 120;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);

            return listadeProductos;
      }
    }
}
