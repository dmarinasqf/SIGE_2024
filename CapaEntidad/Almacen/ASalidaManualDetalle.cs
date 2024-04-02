using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("SalidaManualDetalle", Schema = "Almacen")]

    public class ADetalleSalidaManual
    {

        public int iddetalle { get; set; }
        public int idsalida { get; set; }
        public int? cantidad { get; set; }
        public bool? isblister { get; set; }
        public bool? isfraccion { get; set; }
        public long idstock { get; set; }
        public string estado { get; set; }
      

        //[ForeignKey("idsalida")]
        //public ASalidaManual salida { get; set; }
        //[ForeignKey("idstock")]
        //public AStockLoteProducto stockobj { get; set; }
       
    }
}
