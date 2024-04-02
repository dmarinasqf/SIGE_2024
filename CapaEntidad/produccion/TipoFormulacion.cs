using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.produccion
{
    ////[Table("TipoFormulacion",Schema ="Produccion")]
    public class TipoFormulacion
    {
        //[Key]
        public string idtipoformulacion { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
