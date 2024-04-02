using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CapaEntidad.Generales;
using CapaNegocio;
using CapaPresentacionAdmin.Permisos;


namespace CapaPresentacionAdmin.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        //[PermisosRol(CargoEmpleado1.ADMINISTRADOR)]
        public ActionResult Empleados()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListarEmpleados()
        {
            List<EMPLEADO> oLista = new List<EMPLEADO>();
            
            oLista = new CN_Empleados().Listar();
            //json para mostrar vistas
            return Json( new { data = oLista} , JsonRequestBehavior.AllowGet);
        }

        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            Session["Usuario"] = null;
            return RedirectToAction("Index","Acceso");
        }

        public ActionResult SinPermiso()
        {
            ViewBag.Message = "Usted no cuenta permisos para esta esta pagina";
            return View();
        }



    }
}