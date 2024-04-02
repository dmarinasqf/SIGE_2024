using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class ASalidaManual
    {
        public int idsalida { get; set; }
        public DateTime? fecha { get; set; }
        public int idsucursal { get; set; }
        public int idempresa { get; set; }
        public string estado { get; set; }
        public string motivo { get; set; }
        public string seriedoc { get; set; }
        public string numdoc { get; set; }
        //[NotMapped]
        public string jsondetalle { get; set; }
        //[ForeignKey("idsucursal")]
        //public SUCURSAL sucursal { get; set; }
        //[ForeignKey("idempresa")]
        //public Empresa empresa { get; set; }
    }
}
