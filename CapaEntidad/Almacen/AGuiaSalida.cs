using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Almacen
{

  public  class AGuiaSalida 
    {
	

        public long idguiasalida { get; set; }
        public string codigo { get; set; }
        public DateTime fechatraslado { get; set; }
        public int idsucursal { get; set; }
        public int idalmacensucursalorigen { get; set; }
        public int? idalmacensucursaldestino { get; set; }
        public int idsucursaldestino { get; set; }
        public int idcaja { get; set; }
        public int idcorrelativo { get; set; }       
        public int idempresa { get; set; }        
        public string seriedoc { get; set; }        
        public string numdoc { get; set; }        
        public string estado { get; set; }        
        public string estadoguia { get; set; }        
        public int ano { get; set; }
        public string observacion { get; set; }
        public int? idempresatransporte { get; set; }
        public int? idvehiculo { get; set; }
        public string idempleadoaudita { get; set; }
        public string idempleadomantenimiento { get; set; }
        public int? idproveedor { get; set; }
        public int? idtipoguia { get; set; }
        public int? idventa { get; set; }
        public decimal? peso_total { get; set; }
        public decimal? bultos { get; set; }

        //variables notmapped
        public string encargado  { get; set; }

        public string sucursaldestino  { get; set; }
        public int? IdDistribucion { get; set; }
        public int? idcliente { get; set; }
    }
}
