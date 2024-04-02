using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("SalidaTransferenciaDetalle", Schema = "Almacen")]
  public  class ASalidaTransferenciaDetalle
    {     

        public long idsalidatransferenciadetalle { get; set; }
        public int idproducto { get; set; }
        public long idstock { get; set; }
        public int cantidad { get; set; }  
        public string estado { get; set; }        
        public long idsalidatransferencia { get; set; }
        public string lote { get; set; }
        public string regsanitario { get; set; }
        public DateTime? fechavencimiento { get; set; }
        public int idalmacensucursal { get; set; }
        public bool? isfraccion { get; set; }
    }
}
