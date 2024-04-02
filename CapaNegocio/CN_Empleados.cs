using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad.Generales;

namespace CapaNegocio
{
    public class CN_Empleados
    {
        private CD_Empleados objCapaDato = new CD_Empleados();

        public List<EMPLEADO> Listar()
        {
            return objCapaDato.Listar();       
        }


    }
}
