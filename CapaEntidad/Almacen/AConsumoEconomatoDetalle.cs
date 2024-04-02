using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    public class AConsumoEconomatoDetalle 
    {
        public int idconsumoeconomatodetalle { get; set; }
        public int idconsumoeconomato { get; set; }
        public int idproducto { get; set; }
        public int idstock { get; set; }
        public int cantidad { get; set; }
        public string estado { get; set; }
    }
}
