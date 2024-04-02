using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
  public  class AGuiaEntrada 
    {

        public long idguiaentrada { get; set; }
        public long idguiasalida { get; set; }
        public string codigo { get; set; }
        public DateTime? fecha { get; set; }
        public string idempleado { get; set; }      
        public int idsucursal { get; set; }      
        public int idsucursalenvia { get; set; }      
        public int idalmacensucursal { get; set; } 
        public int idempresa { get; set; } 
        public string estado { get; set; }  
        public string observacion { get; set; }

    }
}
