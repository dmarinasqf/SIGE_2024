using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.pedidos
{
    //[Table("PagosPedido", Schema = "Pedidos")]

    public class PagosPedido 
    {
        //[Key]
        public int idpago { get; set; }       
        public int? idcuenta { get; set; }
        public int? idsucursal { get; set; }
        public int? idtipopago { get; set; }
        public int? idpedido { get; set; }  
        public string estado { get; set; }
        public string numoperacion { get; set; }
        public DateTime? fecha { get; set; }
        public decimal? monto { get; set; }
        public string imagen { get; set; }
        public string usuarioaprueba { get; set; }
        public string observacion { get; set; }
        public bool? validado { get; set; }
        public bool? isinterbancario { get; set; }
        public DateTime? fechaaprobacion { get; set; }
       

    }
}
