using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carretilla_Angular.Models
{
    public class ProductosDTO
    {
        public int idProducto { get; set; }
        public string Descripcion { get; set; }
        public double PrecioQuetzales { get; set; }
        public double PrecioDolares { get; set; }
        public bool enPromocion { get; set; }
        public string slug { get; set; }
        public string categoriaProducto { get; set; }
    }
}