using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class AIngresoTransferencia 
    {
        public long idingresotransferencia { get; set; }
        public string codigo { get; set; }
        public DateTime fecha { get; set; }
        public int idempresa { get; set; }
        public string idempleado { get; set; }
        public int idsucursal { get; set; }
        public int idalmacensucursal { get; set; }
        public int idsucursalenvia { get; set; }
        public long idsalidatransferencia { get; set; }
        public string estado { get; set; }
        public int? ano { get; set; }
        public string observacion { get; set; }        
        public string jsondetalle { get; set; }

    }
}
