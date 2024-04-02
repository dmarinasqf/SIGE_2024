using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("TipoProducto", Schema = "Almacen")]
    public class ATipoProducto
    { 

        public string idtipoproducto { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }       
	
    }
}
