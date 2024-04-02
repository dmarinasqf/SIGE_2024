using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("TipoMovimiento", Schema = "Almacen")]
  public  class ATipoMovimiento
    {

        public int idtipomovimiento { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }        
        public string estado { get; set; }        
    }
}
