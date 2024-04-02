using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("Pais")]
    public class Pais
    {
		//[Key]
		public int idpais { get; set; }
		public string nombre { get; set; }
		public string estado { get; set; }				
	}
}
