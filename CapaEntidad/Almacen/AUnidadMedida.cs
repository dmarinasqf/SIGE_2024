using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("UnidadMedida", Schema = "Almacen")]
   public class AUnidadMedida 
    {
        public int idunidadmedida { get; set; }
		public string abreviatura { get; set; }		
		public string descripcion { get; set; }		
		public string estado { get; set; }
	}
}
