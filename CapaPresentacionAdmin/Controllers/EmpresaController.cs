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
    public class EmpresaController : Controller
    {
        private readonly CS_empleado _empleadoService;

        public EmpresaController()
        {
            _empleadoService = new CS_empleado();
        }
        // GET: Empresa
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult ListarEmpresas()
        {
            DataTable listaEmpresas = _empleadoService.listar_empresas();

            return Json(new { data = listaEmpresas }, JsonRequestBehavior.AllowGet);
        }
    }
}