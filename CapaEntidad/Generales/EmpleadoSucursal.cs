﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Generales
{
    //[Table("UsuarioSucursal")]
  public  class EmpleadoSucursal
    {
        //[Key]
        public int idusuariosucursal { get; set; }
        //[Column("suc_codigo")]
        public int idsucursal { get; set; }
        //[Column("emp_codigo")]
        public int idempleado { get; set; }
        public string tipo { get; set; }
    }
}
