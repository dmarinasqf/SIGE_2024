using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class AHojaRuta
    {

        public long numhojaruta { get; set; }
        public int idempresa { get; set; }
        public int idvehiculo { get; set; }
        public string nomchofer { get; set; }
        public string ayudante { get; set; }
        public string estado { get; set; }
        public int usuacrea { get; set; }
        public DateTime fechacreacion { get; set; }
        public string jsondetalle { get; set; }

    }
}
