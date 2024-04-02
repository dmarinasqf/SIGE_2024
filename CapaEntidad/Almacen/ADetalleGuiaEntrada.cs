using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

  public  class ADetalleGuiaEntrada 
    {     
        public long iddetalleguiaentrada { get; set; }
        public long idguiaentrada { get; set; }
        public int idproducto { get; set; }
        public long idstock { get; set; }
        public int cantidadenviada { get; set; }        
        public int cantidadingresada { get; set; }        
        public string estado { get; set; }     
    }
}
