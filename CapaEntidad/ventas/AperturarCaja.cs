using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.ventas
{
    //[Table("AperturarCaja", Schema = "Ventas")]
    public class AperturarCaja/*:AuditoriaColumna*/
    {
        //[Key]
        public int idaperturacaja { get; set; }
        public string usuarioapertura { get; set; }
        public string usuariocierra { get; set; }
        public DateTime? fechaapertura { get; set; }
        public DateTime? fechacierre { get; set; }
        public string estado { get; set; }
        public string observaciones { get; set; }
        public decimal? montodeposito { get; set; }
        public DateTime? fechadeposito { get; set; }
        
        public decimal? montoinicial { get; set; }
        public int idcajasucursal { get; set; }

        //[ForeignKey("idcajasucursal")]
        //public CajaSucursal cajasucursal { get; set; }
    }
}
