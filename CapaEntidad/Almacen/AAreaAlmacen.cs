using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

   public class AAreaAlmacen
    {
		public int idareaalmacen { get; set; }
		public string descripcion { get; set; }
		//public int? suc_codigo { get; set; }
		public string estado { get; set; }

		//[NotMapped]
		//public string sucursal { get; set; }

		//[ForeignKey(nameof(suc_codigo))]
		//public virtual SUCURSAL sucursal { get; set; }


	}
}
