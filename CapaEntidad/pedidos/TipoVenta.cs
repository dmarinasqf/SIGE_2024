using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.pedidos
{
    //[Table("tipoventa")]

    public class TipoVenta
    {
        //[Key]
        //[Column("idtipoventa")]
        public int? idtipoventa { get; set; }
        public string descripcion { get; set; }      
       
    }
}
