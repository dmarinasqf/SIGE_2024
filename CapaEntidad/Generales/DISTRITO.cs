using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //using System.ComponentModel.DataAnnotations;
    //using System.ComponentModel.DataAnnotations.Schema;


    //[Table("DISTRITO")]
    public partial class DISTRITO
    {
        public int? pro_codigo { get; set; }
        //[Key]
        public int dis_codigo { get; set; }
        //[StringLength(100)]
        public string descripcion { get; set; }
        public string estado { get; set; }


    }
}
