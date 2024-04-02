using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CapaEntidad.Generales;
using CapaPresentacionAdmin.Logica;

namespace CapaPresentacionAdmin.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( string userName, string clave)
        {
            EMPLEADO objeto = new LO_Empleado().EncontrarEmpleados(userName, clave);

            if (objeto.nombres != null)
            {
                FormsAuthentication.SetAuthCookie(objeto.userName, false);
                Session["Usuario"] = objeto;
                return RedirectToAction("Index", "Home");
            }


            return View();
        }
    }
}