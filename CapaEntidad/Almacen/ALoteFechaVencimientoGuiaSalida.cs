using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class ALoteFechaVencimientoGuiaSalida
    {

        public long idlotefechavencimientoguiasalida { get; set; }

        public long iddetalleguiasalida { get; set; }
        public string lote { get; set; }
        public DateTime fechavencimiento { get; set; }
        public int estado { get; set; }
    }
}
