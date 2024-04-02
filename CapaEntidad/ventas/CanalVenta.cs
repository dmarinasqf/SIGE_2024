using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.ventas
{
    //[Table("CanalVenta", Schema = "Ventas")]

    public class CanalVenta
    {
        //[Key]
        public string idcanalventa { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
