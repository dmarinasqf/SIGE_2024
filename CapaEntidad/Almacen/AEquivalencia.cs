using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

   public class AEquivalencia
    {
      
		public int idequivalencia { get; set; }
		public int? unidadmedidainicial { get; set; }
		public int? unidadmedidafinal { get; set; }
		public decimal equivalencia { get; set; }
		public string estado { get; set; }
		public string unidadmedidai { get; set; }
		public string unidadmedidaf { get; set; }
	}
}
