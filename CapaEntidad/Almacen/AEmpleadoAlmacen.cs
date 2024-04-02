using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class AEmpleadoAlmacen
    {
        public int idalmacenempleado { get; set; }
        public int emp_codigo { get; set; }
        public int idalmacen { get; set; }
        public int idareaalmacen { get; set; }
        public string fechacreacion { get; set; }
        public string fechaedicion { get; set; }   
        public string estado { get; set; }
    }
}
