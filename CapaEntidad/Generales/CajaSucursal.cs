using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("CajaSucursal")]

  public  class CajaSucursal
    {
        //[Key]
        public int idcajasucursal { get; set; }
        public int idsucursal { get; set; }
        public int idcaja { get; set; }
        public string estado { get; set; }
        public bool? aperturado { get; set; }
        public string serieimpresora { get; set; }
        public string ipimpresora { get; set; }
        public string nombreimpresora { get; set; }
        public bool? correlativoasociadoaotracaja { get; set; }
        public int? idcajacorrelativoasociado { get; set; }

        //[ForeignKey("idsucursal")]
        //public SUCURSAL sucursal { get; set; }
        //[ForeignKey("idcaja")]
        public Caja caja { get; set; }
    }
}
