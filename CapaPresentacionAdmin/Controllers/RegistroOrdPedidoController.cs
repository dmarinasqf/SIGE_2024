using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDatos; // Asegúrate de tener el espacio de nombres correcto para CD_OPEXPO

namespace CapaPresentacionAdmin.Controllers
{
    public class RegistroOrdPedidoController : Controller
    {
        private readonly CD_OPXBOX.DatosSucursal datosSucursal;
        private readonly CD_OPXBOX.DatosSucursalOP datosSucursalOP;
        private readonly CD_OPXBOX.DatosDiagnostico datosDiagnostico;
        private readonly CD_OPXBOX.DatosLineaAtencion datosLinea;

        public RegistroOrdPedidoController()
        {
            // Crear una nueva instancia de DatosSucursal en el constructor
            datosSucursal = new CD_OPXBOX.DatosSucursal();
            datosSucursalOP = new CD_OPXBOX.DatosSucursalOP();
            datosDiagnostico = new CD_OPXBOX.DatosDiagnostico();
            datosLinea = new CD_OPXBOX.DatosLineaAtencion();
        }

        // GET: RegistroOrdPedido
        public ActionResult Index()
        {
            var sucursalesProduccion = datosSucursal.ObtenerSucursalesProduccion();
            ViewBag.SucursalesProduccion = sucursalesProduccion;
            

            var sucursalesOP = datosSucursalOP.ObtenerSucursalesOP();
            ViewBag.SucursalesOP = sucursalesOP;

            var diagonosticoOP = datosDiagnostico.ObtenerDiagnostico();
            ViewBag.DiagnosticoOP = diagonosticoOP;

            var lineaOP = datosLinea.ObtenerLinea();
            ViewBag.LineaOP = lineaOP;

            return View();

        }


    }
}
