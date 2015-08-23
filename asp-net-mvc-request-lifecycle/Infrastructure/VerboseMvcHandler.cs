using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace asp_net_mvc_request_lifecycle.Infrastructure
{
    public class VerboseMvcHandler : MvcHandler
    {
        private ILog _log = LogManager.GetLogger(typeof(VerboseMvcHandler));

        public VerboseMvcHandler(RequestContext requestContext)
            : base(requestContext)
        {
            _log.Debug("VerboseMvcHandler.ctor(RequestContext requestContext)");
        }

        protected override IAsyncResult BeginProcessRequest(HttpContext httpContext, AsyncCallback callback, object state)
        {
            _log.Debug("VerboseMvcHandler.BeginProcessRequest(HttpContext httpContext, AsyncCallback callback, object state)");
            return base.BeginProcessRequest(httpContext, callback, state);
        }

        protected override void ProcessRequest(HttpContext httpContext)
        {
            _log.Debug("VerboseMvcHandler.ProcessRequest(HttpContext httpContext)");
            base.ProcessRequest(httpContext);
        }
    }
}