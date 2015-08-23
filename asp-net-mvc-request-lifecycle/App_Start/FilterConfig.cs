using asp_net_mvc_request_lifecycle.Infrastructure.Filters;
using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new VerboseActionFilterAttribute());
            filters.Add(new VerboseAuthorizationFilterAttribute());
            filters.Add(new VerboseExceptionFilterAttribute());
            filters.Add(new VerboseResultFilterAttribute());
        }
    }
}
