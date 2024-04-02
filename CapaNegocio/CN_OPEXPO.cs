using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad.Generales;
using CapaEntidad.pedidos;

namespace CapaNegocio
{
   public class CN_OPEXPO
    {
        private CD_OPEXPO objCapaDato = new CD_OPEXPO();

        public List<Pedido> Listar()
        {
            return objCapaDato.Listar();
        }
    }
}
