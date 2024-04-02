using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad.Generales;

namespace CapaPresentacionAdmin.Permisos
{
    public class PermisosRolAttribute : ActionFilterAttribute
    {
        private CargoEmpleado1 idrol;

            public PermisosRolAttribute(CargoEmpleado1 _idcargo)
        {
            idrol = _idcargo;
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(HttpContext.Current.Session["Usuario"]!= null)
            {
                EMPLEADO empleado = HttpContext.Current.Session["Usuario"] as EMPLEADO;

                if(empleado.oCargoEmpleado1 != this.idrol)
                {
                    filterContext.Result = new RedirectResult("~/Home/SinPermiso");
                }
            }
        }
    }
}