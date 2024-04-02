using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("INSTITUCION")]
    public class Institucion
    {
        //[Key]
        public int idInstitucion { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
