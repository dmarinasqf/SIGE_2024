using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    public class AAlmacenProduccion
    {
        
        public int idmovimiento { get; set; }
        public string codigo { get; set; }
        public int idsucursal { get; set; }
        public int idalmacen { get; set; }
        public string observacion { get; set; }
        public int idempresa { get; set; }
        public string jsondetalle { get; set; }
    }
}
