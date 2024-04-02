using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("SucursalLaboratorio")]
    public class SucursalLaboratorio
    {
        //[Key]
        public int idsucursallab { get; set; }
        public int idsucursal { get; set; }
        public int idlaboratorio { get; set; }
        public string estado { get; set; }
    }
}

