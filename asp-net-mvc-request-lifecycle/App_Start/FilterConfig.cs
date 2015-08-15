using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
