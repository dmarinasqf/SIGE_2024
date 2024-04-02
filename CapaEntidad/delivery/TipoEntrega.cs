using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.delivery
{
    //[Table("TipoEntrega",Schema="Delivery")]
   public class TipoEntrega
    {
        //[Key]
        public int idtipoentrega { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
