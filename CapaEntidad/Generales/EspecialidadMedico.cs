using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("ESPECIALIDAD")]
    public class EspecialidadMedico
    {
        //[Key]
        public int esp_codigo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public int idcolegio { get; set; }
    }
}
