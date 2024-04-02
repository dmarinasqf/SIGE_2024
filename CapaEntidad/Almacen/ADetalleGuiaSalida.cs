using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
  public  class ADetalleGuiaSalida 
    {     
        public long iddetalleguiasalida { get; set; }
        public int idproducto { get; set; }
        public long idstock { get; set; }
        public int cantidadgenerada { get; set; }        
        public int cantidadpicking { get; set; }        
        public int? cantidadanterior { get; set; }        
        public string estado { get; set; }        
        public long idguiasalida { get; set; }
        public int idsucusaldestino { get; set; }
        public string producto { get; set; }
        public string lotecliente { get; set; }
        public string fechavencimientocliente { get; set; }

    }
}
