using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("Kardex", Schema = "Almacen")]

    public class Kardex
    {

        public long id { get; set; }
        public string tipo { get; set; }
        public string movimiento { get; set; }
        public long idstock { get; set; }
        public int idproducto { get; set; }
        public int? idalmacen { get; set; }
        public decimal? cantidad { get; set; }
        public decimal? stockactual { get; set; }
        public decimal? multiplo { get; set; }
        public string tabla { get; set; }
        public string idtabla { get; set; }
        public string estado { get; set; }

        //[ForeignKey("idstock")]
        //public AStockLoteProducto stocklote { get; set; }
        //[ForeignKey("idproducto")]
        //public AProducto producto { get; set; }
        //[ForeignKey("idalmacen")]
        public AAlmacenSucursal  almacensucursal { get; set; }

    }
}
