using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{
    //[Table("TipoGuia", Schema = "Almacen")]
    public class ATipoGuia
    {

        public int idtipoguia { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
