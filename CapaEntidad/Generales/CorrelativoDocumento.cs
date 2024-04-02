using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("CorrelativoDocumento")]
    public class CorrelativoDocumento
    {

        public int idcorrelativo { get; set; }
        public int idcajasucursal { get; set; }
        public int iddocumento { get; set; }
        public string serie { get; set; }
        public int? empieza { get; set; }
        public int? termina { get; set; }
        public int? actual { get; set; }
        public string estado { get; set; }
        public CajaSucursal cajasucursal { get; set; }
        //public FDocumentoTributario documentoTributario { get; set; }

    }
}
