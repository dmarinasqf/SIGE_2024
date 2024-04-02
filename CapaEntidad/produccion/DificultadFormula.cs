using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.produccion
{
    //[Table("DIFICULTADFORMULA")]
    public class DificultadFormula
    {
        //[Key]
        public int iddificultad { get; set; } 
        public string descripcion { get; set; }     
        public string estado { get; set; }     
    }
}
