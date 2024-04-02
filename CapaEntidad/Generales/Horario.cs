using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("HORARIO")]
    public class Horario
    {
        public int horario_codigo { get; set; }
        public int med_codigo { get; set; }
        public int suc_codigo { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int emp_codigo { get; set; }
        public int tur_codigo { get; set; }
        public int consultorio_codigo { get; set; }
        //[StringLength(30)]
        public string estado { get; set; }
        public int? nmrConsultas { get; set; }
    }
}
