using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("Almacen", Schema = "TipoSalida")]
   public class ATipoSalida
    {

		public int idtiposalida { get; set; }
		public string descripcion { get; set; }
		public string estado { get; set; }
    }
}
