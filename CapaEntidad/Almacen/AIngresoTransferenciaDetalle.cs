using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

  public  class AIngresoTransferenciaDetalle
    {
        public long idingresotransferenciadetalle { get; set; }
        public int idproducto { get; set; }
        public long idstock { get; set; }
        public int cantidad { get; set; }  
        public string estado { get; set; }        
        public long idingresotransferencia { get; set; }
        public string lote { get; set; }
        public string regsanitario { get; set; }
        public DateTime? fechavencimiento { get; set; }
        public int idalmacensucursal { get; set; }
        public bool? isfraccion { get; set; }
    }
}
