using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace asp_net_mvc_request_lifecycle.Infrastructure
{
    public class VerboseControllerActionInvoker : ControllerActionInvoker
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(VerboseControllerActionInvoker));

        public VerboseControllerActionInvoker()
        {
            _log.Debug("VerboseControllerActionInvoker.ctor()");
        }

        protected override ActionResult CreateActionResult(ControllerContext controllerContext, 
            ActionDescriptor actionDescriptor, object actionReturnValue)
        {
            _log.Debug("VerboseControllerActionInvoker.CreateActionResult(ControllerContext controllerContext, ActionDescriptor actionDescriptor, object actionReturnValue)");
            return base.CreateActionResult(controllerContext, actionDescriptor, actionReturnValue);
        }
        
        protected override ActionDescriptor FindAction(ControllerContext controllerContext, ControllerDescriptor controllerDescriptor, string actionName)
        {
            _log.Debug("VerboseControllerActionInvoker.FindAction(ControllerContext controllerContext, ControllerDescriptor controllerDescriptor, string actionName)");
            return base.FindAction(controllerContext, controllerDescriptor, actionName);
        }

        protected override ControllerDescriptor GetControllerDescriptor(ControllerContext controllerContext)
        {
            _log.Debug("VerboseControllerActionInvoker.GetControllerDescriptor(ControllerContext controllerContext)");
            return base.GetControllerDescriptor(controllerContext);
        }

        protected override FilterInfo GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            _log.Debug("VerboseControllerActionInvoker.GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)");
            return base.GetFilters(controllerContext, actionDescriptor);
        }

        protected override object GetParameterValue(ControllerContext controllerContext, ParameterDescriptor parameterDescriptor)
        {
            _log.Debug("VerboseControllerActionInvoker.GetParameterValue(ControllerContext controllerContext, ParameterDescriptor parameterDescriptor)");
            return base.GetParameterValue(controllerContext, parameterDescriptor);
        }

        protected override IDictionary<string, object> GetParameterValues(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            _log.Debug("VerboseControllerActionInvoker.GetParameterValues(ControllerContext controllerContext, ActionDescriptor actionDescriptor)");
            return base.GetParameterValues(controllerContext, actionDescriptor);
        }

        public override bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeAction(ControllerContext controllerContext, string actionName)");
            return base.InvokeAction(controllerContext, actionName);
        }

        protected override ActionResult InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary<string, object> parameters)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary<string, object> parameters)");
            return base.InvokeActionMethod(controllerContext, actionDescriptor, parameters);
        }

        protected override ActionExecutedContext InvokeActionMethodWithFilters(ControllerContext controllerContext, IList<IActionFilter> filters, ActionDescriptor actionDescriptor, IDictionary<string, object> parameters)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeActionMethodWithFilters(ControllerContext controllerContext, IList<IActionFilter> filters, ActionDescriptor actionDescriptor, IDictionary<string, object> parameters)");
            return base.InvokeActionMethodWithFilters(controllerContext, filters, actionDescriptor, parameters);
        }

        protected override void InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult)");
            base.InvokeActionResult(controllerContext, actionResult);
        }

        protected override ResultExecutedContext InvokeActionResultWithFilters(ControllerContext controllerContext, IList<IResultFilter> filters, ActionResult actionResult)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeActionResultWithFilters(ControllerContext controllerContext, IList<IResultFilter> filters, ActionResult actionResult)");
            return base.InvokeActionResultWithFilters(controllerContext, filters, actionResult);
        }

        protected override AuthenticationContext InvokeAuthenticationFilters(ControllerContext controllerContext, IList<IAuthenticationFilter> filters, ActionDescriptor actionDescriptor)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeAuthenticationFilters(ControllerContext controllerContext, IList<IAuthenticationFilter> filters, ActionDescriptor actionDescriptor)");
            return base.InvokeAuthenticationFilters(controllerContext, filters, actionDescriptor);
        }

        protected override AuthenticationChallengeContext InvokeAuthenticationFiltersChallenge(ControllerContext controllerContext, IList<IAuthenticationFilter> filters, ActionDescriptor actionDescriptor, ActionResult result)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeAuthenticationFiltersChallenge(ControllerContext controllerContext, IList<IAuthenticationFilter> filters, ActionDescriptor actionDescriptor, ActionResult result)");
            return base.InvokeAuthenticationFiltersChallenge(controllerContext, filters, actionDescriptor, result);
        }

        protected override AuthorizationContext InvokeAuthorizationFilters(ControllerContext controllerContext, IList<IAuthorizationFilter> filters, ActionDescriptor actionDescriptor)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeAuthorizationFilters(ControllerContext controllerContext, IList<IAuthorizationFilter> filters, ActionDescriptor actionDescriptor)");
            return base.InvokeAuthorizationFilters(controllerContext, filters, actionDescriptor);
        }

        protected override ExceptionContext InvokeExceptionFilters(ControllerContext controllerContext, IList<IExceptionFilter> filters, Exception exception)
        {
            _log.Debug("VerboseControllerActionInvoker.InvokeExceptionFilters(ControllerContext controllerContext, IList<IExceptionFilter> filters, Exception exception)");
            return base.InvokeExceptionFilters(controllerContext, filters, exception);
        }
    }
}