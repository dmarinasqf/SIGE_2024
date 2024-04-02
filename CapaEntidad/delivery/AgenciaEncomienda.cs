using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.delivery
{
    //[Table("AgenciaEncomienda")]
    public class AgenciaEncomienda
    {
        //[Key]
        public int idagencia { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
