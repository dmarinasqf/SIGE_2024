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
    public class CS_empleado
    {

        private string url;

        public CS_empleado() { 
            url = ConfigurationManager.AppSettings["urlws"] + "Login/ServiceLogin.svc/";
        }

        WebClient cliente = new WebClient() { Encoding = Encoding.UTF8 };

        public DataTable listar_empresas()
        {
            try {
                var json = cliente.DownloadString(url + "empresas");
                var jsonobj = JsonConvert.DeserializeObject(json);
                var lista = JsonConvert.DeserializeObject<DataTable>(jsonobj.ToString());
                return lista;

            }
            catch (Exception vEx) { return null; }
        

        }

    }
}
