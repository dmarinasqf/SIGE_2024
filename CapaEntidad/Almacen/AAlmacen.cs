using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

   public class AAlmacen
    {
        
		public int idalmacen { get; set; }
		public string descripcion { get; set; }
		public string tipoalmacen { get; set; }
		public string estado { get; set; }
        public string idtipoproducto { get; set; }

    }
}
