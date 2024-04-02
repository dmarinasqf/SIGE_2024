using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    
    //[Table("EMPLEADO")]
    public class EMPLEADO
    {

        public int? suc_codigo { get; set; }
        public SUCURSAL oSUCURSAL { get; set; }
        public string perfil_codigo { get; set; }
        public int emp_codigo { get; set; }
        public string Sucursal { get; set; }
        public string Nombres { get; set; }
        public string apePaterno { get; set; }
        public string apeMaterno { get; set; }
        public string documento { get; set; }
        public string estado { get; set; }
        public string userName { get; set; }
        public string clave { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string foto { get; set; }
        public bool? permitirDescuentoTeste { get; set; }
        public int? idgrupo { get; set; }
        public int? idcargo { get; set; }
        public CargoEmpleado1 oCargoEmpleado1 { get; set; }
        //[NotMapped]
        public string local { get; set; }
        //[NotMapped]
        public string Grupo { get; set; }
        public string Empresa { get; set; }
        //[NotMapped]
        public List<string> CanalVentas { get; set; }
        //[NotMapped]

        public List<int> Sucursales { get; set; }

        //[ForeignKey(nameof(suc_codigo))]
        //public  SUCURSAL sucursal { get; set; }
        //[ForeignKey(nameof(emp_codigo))]
        //public virtual USUARIO usuario { get; set; }
    }
}
