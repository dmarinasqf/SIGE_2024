using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    public class AAlmacenSucursal
    {
		public int idalmacensucursal { get; set; }
		public int? idalmacen { get; set; }		
		public int? idareaalmacen { get; set; }
		public int? suc_codigo { get; set; }
		public string estado { get; set; }		
		public string almacen { get; set; }
		public string areaalmacen { get; set; }
		public int estadoalmacen { get; set; }
		public string sucursal { get; set; }

	}
}
