using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{


    public class ADetallePrincipioActivo
    {

        public int iddetalle { get; set; }
        public int idproducto { get; set; }
        public int idprincipio { get; set; }
        public int? idunidadmedida { get; set; }
        public string codconcentracion { get; set; }
    }
}