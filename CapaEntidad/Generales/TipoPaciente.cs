using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("TIPOPACIENTE")]
    public class TipoPaciente
    {

        //[Key]
        //[Column("tipopaciente_codigo")]
        public int idtipopaciente { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }


    }
}
