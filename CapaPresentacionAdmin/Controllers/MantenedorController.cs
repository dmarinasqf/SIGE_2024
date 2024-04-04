using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CapaEntidad.Generales;
using CapaNegocio;
using CapaPresentacionAdmin.Permisos;
using CapaService;


namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Clase()
        {
            return View();
        }
        public ActionResult Subclase()
        {
            return View();
        }
        public ActionResult TipProducto()
        {
            return View();
        }
        public ActionResult UnidadMedida()
        {
            return View();
        }
        public ActionResult Laboratorio()
        {
            return View();
        }
        public ActionResult PreciosProd()
        {
            return View();
        }
        public ActionResult ListaPreProd()
        {
            return View();
        }
        public ActionResult Producto()
        {
            return View();
        }
        CS_producto emp = new CS_producto();


        [HttpGet]
        public JsonResult ListarEmpleados()
        {
            List<EMPLEADO> oLista = new List<EMPLEADO>();

            oLista = new CN_Empleados().Listar();
            DataTable dt = new DataTable();

            dt = emp.listar_productos();

            //json para mostrar vistas
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
        }
    }
}