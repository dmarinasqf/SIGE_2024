using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{


    public class ADristribucionProducto
    {
        public int IdDistribucion { get; set; }

        public DateTime Fechacreacion { get; set; }
        public int idsucursalorigen { get; set; }
        public int idempresaorigen { get; set; }
        public int usuariocreacion { get; set; }
        public int estado { get; set; }
      

    }
}
