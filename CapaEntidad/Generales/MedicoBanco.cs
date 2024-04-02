using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("MedicoBanco")]
    public class MedicoBanco
    {
        //[Key]
        public int iddetalle { get; set; }
        public int idmedico { get; set; }
        public int idbanco { get; set; }
        public string cuenta { get; set; }
        public string estado { get; set; }
        public string cci { get; set; }
    }
}
