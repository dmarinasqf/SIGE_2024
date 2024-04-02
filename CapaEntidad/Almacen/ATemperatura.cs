using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("Temperatura", Schema = "Almacen")]
  public  class ATemperatura 
    {
        //[Key]
        public int idtemperatura { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }        
    }
}
