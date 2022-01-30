using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quieropizza.web
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
    }

}