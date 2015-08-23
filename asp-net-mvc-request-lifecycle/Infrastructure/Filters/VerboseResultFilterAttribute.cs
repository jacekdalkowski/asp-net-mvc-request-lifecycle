using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle.Infrastructure.Filters
{
    public class VerboseResultFilterAttribute : ActionFilterAttribute, IResultFilter
    {
        private ILog _log = LogManager.GetLogger(typeof(VerboseResultFilterAttribute));

        public virtual void OnResultExecuting(ResultExecutingContext filterContext)
        {
            _log.Debug("VerboseResultFilterAttribute.OnResultExecuting(ResultExecutingContext filterContext)");
        }

        public virtual void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _log.Debug("VerboseResultFilterAttribute.OnResultExecuted(ResultExecutedContext filterContext)");
        }    
    }
}