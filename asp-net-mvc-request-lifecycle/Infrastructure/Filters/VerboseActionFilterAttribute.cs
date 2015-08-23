using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle.Infrastructure.Filters
{
    public class VerboseActionFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(VerboseActionFilterAttribute));

        public virtual void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _log.Debug("VerboseActionFilterAttribute.OnActionExecuting(ActionExecutingContext filterContext)");
        }

        public virtual void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _log.Debug("VerboseActionFilterAttribute.OnActionExecuted(ActionExecutedContext filterContext)");
        }
    }
}