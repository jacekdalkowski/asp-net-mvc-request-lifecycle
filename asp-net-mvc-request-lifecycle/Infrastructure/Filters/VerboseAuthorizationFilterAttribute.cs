using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle.Infrastructure.Filters
{
    public class VerboseAuthorizationFilterAttribute : ActionFilterAttribute, IAuthorizationFilter
    {
        private ILog _log = LogManager.GetLogger(typeof(VerboseAuthorizationFilterAttribute));

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            _log.Debug("VerboseAuthorizationFilterAttribute.OnAuthorization(AuthorizationContext filterContext)");
        }
    }
}