using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class AAlmacenProduccionDetalle
    {
        public int idmovimiento { get; set; }
        public int iddetalle { get; set; }
        public int idproducto { get; set; }
        public int idstock { get; set; }
        public int cantidad { get; set; }
        public string iduma { get; set; }

    }
}
