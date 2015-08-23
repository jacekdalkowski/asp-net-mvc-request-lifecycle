using asp_net_mvc_request_lifecycle.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace asp_net_mvc_request_lifecycle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add("Default", new Route("{controller}/{action}/{id}", new VerboseMvcRouteHandler())
            {
                Defaults = new RouteValueDictionary(new { controller = "Home", action = "Index", id = UrlParameter.Optional })
            });
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
