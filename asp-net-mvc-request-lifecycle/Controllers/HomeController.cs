using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace asp_net_mvc_request_lifecycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(HomeController));

        public HomeController()
        {
            _log.Debug("HomeController.ctor()");
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            _log.Debug("HomeController.BeginExecute()");
            return base.BeginExecute(requestContext, callback, state);
        }

        protected override void Initialize(RequestContext requestContext)
        {
            _log.Debug("HomeController.Initialize(RequestContext requestContext)");
            base.Initialize(requestContext);
        }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            _log.Debug("HomeController.BeginExecuteCore(AsyncCallback callback, object state)");
            return base.BeginExecuteCore(callback, state);
        }

        protected override ITempDataProvider CreateTempDataProvider()
        {
            _log.Debug("HomeController.CreateTempDataProvider()");
            return base.CreateTempDataProvider();
        }

        protected override IActionInvoker CreateActionInvoker()
        {
            _log.Debug("HomeController.CreateActionInvoker()");
            return base.CreateActionInvoker();
        }

        public ActionResult Index()
        {
            _log.Debug("HomeController.Index()");
            return View();
        }
    }
}