using CapaEntidad;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class AInventarioDetalle 
    {
        public int idinventariodetalle { get; set; }
        public int idinventario { get; set; }
        public int idstock { get; set; }
        //public int cantidadanterior { get; set; }
        public int cajas { get; set; }
        public int unidad { get; set; }
        public string estado { get; set; }
    }
}
