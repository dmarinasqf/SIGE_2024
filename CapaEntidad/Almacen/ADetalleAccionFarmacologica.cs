using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

  public  class ADetalleAccionFarmacologica 
    {
        public int iddetalleaccionfarma { get; set; }
        public int? idaccionfarma { get; set; }
        public int? idproducto { get; set; }   
        public string acccionfarmacologica { get; set; }
    }
}
