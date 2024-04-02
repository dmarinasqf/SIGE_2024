using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad.Generales;
using CapaEntidad.pedidos;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class OrdPedidoController : Controller
    {
         //[Authorize]
        public ActionResult OrdPedido()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListarOrdPedido()
        {
            List<Pedido> oLista = new List<Pedido>();

            oLista = new CN_OPEXPO().Listar();
            //json para mostrar vistas
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
        }



    }
}