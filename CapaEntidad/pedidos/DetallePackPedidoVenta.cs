using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.pedidos
{
    //[Table("DetallePackPedidoVenta")]

    public class DetallePackPedidoVenta 
    {
        //[Key]
        public int? idpackPedidoVenta { get; set; }
        public int? idpedido_codigo { get; set; }
        public decimal? precioproductopack { get; set; }
        public int? cantidadPacks { get; set; }
        public decimal? precioTotalPacks { get; set; }
        public int? idpromopack { get; set; }
        public DateTime? fechacreacion { get; set; }

        public decimal? precioSindescuento { get; set; }
        public decimal? cantidadDescuento { get; set; }
        public decimal? porcentajedescuento { get; set; }
        public decimal? precioIgvpack { get; set; }
        public string Nombredepack { get; set; }
        public string Codigopack { get; set; }
        public string idtipotributo { get; set; }
        
    }

}
