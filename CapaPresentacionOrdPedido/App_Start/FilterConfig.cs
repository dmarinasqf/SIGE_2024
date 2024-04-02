using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionOrdPedido
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
