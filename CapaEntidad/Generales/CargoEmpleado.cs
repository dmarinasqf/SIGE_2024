using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("CargoEmpleado")]
    public class CargoEmpleado
    {
        //[Key]
        public int idcargo { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }
    }
}
