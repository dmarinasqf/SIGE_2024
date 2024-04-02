using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("Caja")]
    public class Caja
    {
        //[Key]
        public int idcaja { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
