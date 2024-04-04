using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaService
{
   public class CS_producto
    {
        private string url;

        public CS_producto()
        {
            url = ConfigurationManager.AppSettings["urlws"] + "ServicesGenerales/ServiceGenerales.svc/";
        }

        WebClient producto = new WebClient() { Encoding = Encoding.UTF8 };

        public DataTable listar_productos()
        {
            try
            {
                var json = producto.DownloadString(url + "listar_productosxlab/{idlaboratorio}");
                var jsonobj = JsonConvert.DeserializeObject(json);
                var lista = JsonConvert.DeserializeObject<DataTable>(jsonobj.ToString());
                return lista;

            }
            catch (Exception vEx) { return null; }


        }
    }
}
