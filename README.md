# asp-net-mvc-request-lifecycle
Application logging request processing in asp.net mvc


MvcApplication - MvcApplication.Init() 

MvcApplication - MvcApplication.OnBeginRequest 

MvcApplication - MvcApplication.OnAuthenticateRequest 

MvcApplication - MvcApplication.OnPostAuthenticateRequest 

MvcApplication - MvcApplication.OnAuthorizeRequest 

MvcApplication - MvcApplication.OnPostAuthorizeRequest 

MvcApplication - MvcApplication.OnResolveRequestCache 

Infrastructure.VerboseMvcRouteHandler - VerboseMvcRouteHandler.GetHttpHandler(RequestContext requestContext) - returning VerboseMvcHandler 

Infrastructure.VerboseMvcHandler - VerboseMvcHandler.ctor(RequestContext requestContext) 

MvcApplication - MvcApplication.OnPostResolveRequestCache 

MvcApplication - MvcApplication.OnMapRequestHandler 

MvcApplication - MvcApplication.OnAcquireRequestState 

MvcApplication - MvcApplication.OnPostAcquireRequestState 

MvcApplication - MvcApplication.OnPreRequestHandlerExecute 

Infrastructure.VerboseMvcHandler - VerboseMvcHandler.BeginProcessRequest(HttpContext httpContext, AsyncCallback callback, object state) 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: System.Web.Mvc.IControllerFactory 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.VerboseControllerFactory - VerboseControllerFactory.CreateController(System.Web.Routing.RequestContext requestContext, string controllerName) 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: System.Web.Mvc.IControllerActivator 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: Controllers.HomeController 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning instance of HomeController. 

Controllers.HomeController - HomeController.ctor() 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.ctor() 

Controllers.HomeController - HomeController.BeginExecute() 

Controllers.HomeController - HomeController.Initialize(RequestContext requestContext) 

Controllers.HomeController - HomeController.BeginExecuteCore(AsyncCallback callback, object state) 

Controllers.HomeController - HomeController.CreateTempDataProvider() 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: System.Web.Mvc.ITempDataProviderFactory 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: System.Web.Mvc.ITempDataProvider 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeAction(ControllerContext controllerContext, string actionName) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.GetControllerDescriptor(ControllerContext controllerContext) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.FindAction(ControllerContext controllerContext, ControllerDescriptor controllerDescriptor, string actionName) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor) 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), serviceType: System.Web.Mvc.IFilterProvider 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), returning an empty array. 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeAuthenticationFilters(ControllerContext controllerContext, IList<IAuthenticationFilter> filters, ActionDescriptor actionDescriptor) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeAuthorizationFilters(ControllerContext controllerContext, IList<IAuthorizationFilter> filters, ActionDescriptor actionDescriptor) 

Infrastructure.Filters.VerboseAuthorizationFilterAttribute - VerboseAuthorizationFilterAttribute.OnAuthorization(AuthorizationContext filterContext) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.GetParameterValues(ControllerContext controllerContext, ActionDescriptor actionDescriptor) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.GetParameterValue(ControllerContext controllerContext, ParameterDescriptor parameterDescriptor) 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), serviceType: System.Web.Mvc.IModelBinderProvider 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), returning an empty array. 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), serviceType: System.Web.Mvc.ValueProviderFactory 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), returning an empty array. 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: System.Web.Mvc.ModelMetadataProvider 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.VerboseModelBinder - VerboseModelBinder.BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeActionMethodWithFilters(ControllerContext controllerContext, IList<IActionFilter> filters, ActionDescriptor actionDescriptor, IDictionary<string, object> parameters) 

Infrastructure.Filters.VerboseActionFilterAttribute - VerboseActionFilterAttribute.OnActionExecuting(ActionExecutingContext filterContext) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary<string, object> parameters) 

Controllers.HomeController - HomeController.Index() 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.CreateActionResult(ControllerContext controllerContext, ActionDescriptor actionDescriptor, object actionReturnValue) 

Infrastructure.Filters.VerboseActionFilterAttribute - VerboseActionFilterAttribute.OnActionExecuted(ActionExecutedContext filterContext) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeAuthenticationFiltersChallenge(ControllerContext controllerContext, IList<IAuthenticationFilter> filters, ActionDescriptor actionDescriptor, ActionResult result) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeActionResultWithFilters(ControllerContext controllerContext, IList<IResultFilter> filters, ActionResult actionResult) 

Infrastructure.Filters.VerboseResultFilterAttribute - VerboseResultFilterAttribute.OnResultExecuting(ResultExecutingContext filterContext) 

Infrastructure.VerboseControllerActionInvoker - VerboseControllerActionInvoker.InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult) 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), serviceType: System.Web.Mvc.IViewEngine 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetServices(Type serviceType), returning an empty array. 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: System.Web.Mvc.IViewPageActivator 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: ASP._Page_Views_Home_Index_cshtml 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType), serviceType: ASP._Page_Views_Shared__LoginPartial_cshtml 

Infrastructure.VerboseDependencyResolver - VerboseDependencyResolver.GetService(Type serviceType) returning null. 

Infrastructure.Filters.VerboseResultFilterAttribute - VerboseResultFilterAttribute.OnResultExecuted(ResultExecutedContext filterContext) 

MvcApplication - MvcApplication.OnPostRequestHandlerExecute 

MvcApplication - MvcApplication.OnReleaseRequestState 

MvcApplication - MvcApplication.OnPostReleaseRequestState 

MvcApplication - MvcApplication.OnUpdateRequestCache 

MvcApplication - MvcApplication.OnPostUpdateRequestCache 

MvcApplication - MvcApplication.OnLogRequest 

MvcApplication - MvcApplication.OnPostLogRequest 

MvcApplication - MvcApplication.OnEndRequest 

MvcApplication - MvcApplication.OnPreSendRequestHeaders 

MvcApplication - MvcApplication.OnPreSendRequestContent 

MvcApplication - MvcApplication.OnRequestCompleted 
