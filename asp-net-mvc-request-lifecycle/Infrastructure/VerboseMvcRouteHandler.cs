using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace asp_net_mvc_request_lifecycle.Infrastructure
{
    public class VerboseMvcRouteHandler : MvcRouteHandler
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(VerboseMvcRouteHandler));

        public VerboseMvcRouteHandler()
            : base()
        {
            _log.Debug("VerboseMvcRouteHandler.ctor()");
        }

        public VerboseMvcRouteHandler(IControllerFactory controllerFactory)
        {
            _log.Debug("VerboseMvcRouteHandler.ctor(IControllerFactory controllerFactory)");
        }

        protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            _log.Debug("VerboseMvcRouteHandler.GetHttpHandler(RequestContext requestContext) - returning VerboseMvcHandler");
            return new VerboseMvcHandler(requestContext);
        }

        protected override SessionStateBehavior GetSessionStateBehavior(RequestContext requestContext)
        {
            _log.Debug("VerboseMvcRouteHandler.GetSessionStateBehavior(RequestContext requestContext)");
            return base.GetSessionStateBehavior(requestContext);
        }
    }
}