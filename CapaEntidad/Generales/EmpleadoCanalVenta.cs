using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("EmpleadoCanalVenta")]
   public class EmpleadoCanalVenta
    {
        //[Key]
        public int iddetalle { get; set; }
        public int idempleado { get; set; }
        public string idcanalventa { get; set; }
    }
}
