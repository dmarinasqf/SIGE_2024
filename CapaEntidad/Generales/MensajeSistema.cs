using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("mensajessistema")]
   public class MensajeSistema
    {
        //[Key]
        public long id { get; set; }
        public string descripcion { get; set; }
        public string modulo { get; set; }
        public DateTime? fecha { get; set; }
        public bool? visto { get; set; }
        public string tipo { get; set; }
    }
}
