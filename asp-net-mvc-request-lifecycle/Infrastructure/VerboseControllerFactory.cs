using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle.Infrastructure
{
    public class VerboseControllerFactory : DefaultControllerFactory
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(VerboseControllerFactory));

        public override IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            _log.Debug("VerboseControllerFactory.CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)");
            IController iController = base.CreateController(requestContext, controllerName);
            if (iController is Controller)
            {
                Controller controller = iController as Controller;
                controller.ActionInvoker = new VerboseControllerActionInvoker();
            }
            return iController;
        }
    }
}