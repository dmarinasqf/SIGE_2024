using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("TIPO_ORIGEN")]
  public  class TipoOrigenReceta
    {
        //[Key]
        //[Column("tipoorigen_codigo")]
        public int idtipo { get; set; }
     
        public string descripcion { get; set; }
    }
}
