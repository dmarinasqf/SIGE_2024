﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.pedidos
{
    //[Table("DetallePedidoEstadoProceso", Schema = "Pedidos")]
    public class DetallePedidoEstadoProceso
    {
        //[Key]
        public int iddetallepedidoestadoproceso { get; set; }
        public int detp_codigo { get; set; }
        public string estadoproceso { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
    }
}