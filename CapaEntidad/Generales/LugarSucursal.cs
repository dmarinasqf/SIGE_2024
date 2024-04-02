using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("LugarSucursal")]

    public class LugarSucursal
    {
      
            //[Key]
            public int idlugar { get; set; }
            public string descripcion { get; set; }
            public string estado { get; set; }
        
    }
}
