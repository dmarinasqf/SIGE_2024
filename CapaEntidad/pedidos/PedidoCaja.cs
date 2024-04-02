using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.pedidos
{
    //--EARTCOD1011--//
    //[Table("PedidoCaja", Schema = "Pedidos")]
    public class PedidoCaja
    {
        //[Key]
        public int idpedidocaja { get; set; }
        public int idpedido { get; set; }
        public int idaperturacaja { get; set; }
        public int? idtipotarjeta { get; set; }
    }
}
