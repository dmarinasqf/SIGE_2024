using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("Colegio")]
    public class ColegioMedico
    {

        public int idcolegio { get; set; }
        public string abreviatura { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public int? nmrdigitos { get; set; }

    }
}
