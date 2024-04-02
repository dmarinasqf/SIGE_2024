using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class AConsumoEconomato
    {

        public int idconsumoeconomato { get; set; }
        public string numdocumento { get; set; }
        public string motivo { get; set; }
        public string estado { get; set; }
        public int? suc_codigo { get; set; }
        public string jsondetalle { get; set; }
    }
}
