using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle.Infrastructure.Filters
{
    public class VerboseExceptionFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        private ILog _log = LogManager.GetLogger(typeof(VerboseExceptionFilterAttribute));

        public void OnException(ExceptionContext filterContext)
        {
            _log.Debug("VerboseExceptionFilterAttribute.OnException(ExceptionContext filterContext)");
        }
    }
}