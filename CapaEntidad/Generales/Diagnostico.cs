using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("DIAGNOSTICO")]
    public class Diagnostico
    {
        //[Key]
        //[Column("diagnostico_codigo")]
        public int iddiagnostico { get; set; }
        public string descripcion { get; set; }
        public string codigo { get; set; }       
        public string estado { get; set; }
    }
}
