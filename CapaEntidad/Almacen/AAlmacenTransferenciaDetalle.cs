using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

    public class AAlmacenTransferenciaDetalle 
    {
        public int idalmacentransferenciadetalle { get; set; }
        public int idalmacentransferencia { get; set; }
        public int idproducto { get; set; }
        public int idstockorigen { get; set; }
        public decimal cantidad { get; set; }
        public int idstockdestino { get; set; }
        public string estado { get; set; }
    }
}
