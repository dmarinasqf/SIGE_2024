using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{


    public class AIngresoManual
    {

        public int idingreso { get; set; }
        public DateTime? fecha { get; set; }
        public int idsucursal { get; set; }
        public int idempresa { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
        public string jsondetalle { get; set; }

    }
}
