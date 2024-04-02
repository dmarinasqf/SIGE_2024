using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

  public  class ADetalleProductoGenerico 
    {
        
        public int iddetallegenerico { get; set; }
        public int? idproducto { get; set; }
        public int? idproductogenerico { get; set; }
        public string descripcion { get; set; }
        public string codconcentracion { get; set; }
        public string unidadmedida { get; set; }
        public string nombreabreviado { get; set; }

    }
}
