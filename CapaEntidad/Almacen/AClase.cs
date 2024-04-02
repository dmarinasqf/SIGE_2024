using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
  public  class AClase
    {
        public int idclase { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }  
        public AClase oAClase { get; set; }
    }
}
