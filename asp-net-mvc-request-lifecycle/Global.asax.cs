using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace asp_net_mvc_request_lifecycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static ILog _log = LogManager.GetLogger(typeof(MvcApplication));

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        public override void Init()
        {
            base.Init();
            BeginRequest += OnBeginRequest;
            AuthenticateRequest += OnAuthenticateRequest;
            PostAuthenticateRequest += OnPostAuthenticateRequest;
            AuthorizeRequest += OnAuthorizeRequest;
            PostAuthorizeRequest += OnPostAuthorizeRequest;
            ResolveRequestCache += OnResolveRequestCache;
            PostResolveRequestCache += OnPostResolveRequestCache;
            MapRequestHandler += OnMapRequestHandler;

            AcquireRequestState += OnAcquireRequestState;
            PostAcquireRequestState += OnPostAcquireRequestState;
            PreRequestHandlerExecute += OnPreRequestHandlerExecute;
            PostRequestHandlerExecute += OnPostRequestHandlerExecute;
            ReleaseRequestState += OnReleaseRequestState;
            PostReleaseRequestState += OnPostReleaseRequestState;
            UpdateRequestCache += OnUpdateRequestCache;
            PostUpdateRequestCache += OnPostUpdateRequestCache;
            RequestCompleted += OnRequestCompleted;
            EndRequest += OnEndRequest;

            PreSendRequestHeaders += OnPreSendRequestHeaders;
            PreSendRequestContent += OnPreSendRequestContent;
            Error += OnError;
            Disposed += OnDisposed;
            LogRequest += OnLogRequest;
            PostLogRequest += OnPostLogRequest;
        }

        public void OnAcquireRequestState(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnAcquireRequestState");
        }

        public void OnAuthenticateRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnAuthenticateRequest");
        }

        public void OnAuthorizeRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnAuthorizeRequest");
        }

        public void OnBeginRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnBeginRequest");
        }

        public void OnDisposed(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnDisposed");
        }

        public void OnEndRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnEndRequest");
        }

        public void OnError(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnError");
        }

        public void OnLogRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnLogRequest");
        }

        public void OnMapRequestHandler(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnMapRequestHandler");
        }

        public void OnPostAcquireRequestState(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostAcquireRequestState");
        }

        public void OnPostAuthenticateRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostAuthenticateRequest");
        }

        public void OnPostAuthorizeRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostAuthorizeRequest");
        }

        public void OnPostLogRequest(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostLogRequest");
        }

        public void OnPostMapRequestHandler(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostMapRequestHandler");
        }

        public void OnPostReleaseRequestState(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostReleaseRequestState");
        }

        public void OnPostRequestHandlerExecute(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostRequestHandlerExecute");
        }

        public void OnPostResolveRequestCache(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostResolveRequestCache");
        }

        public void OnPostUpdateRequestCache(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPostUpdateRequestCache");
        }

        public void OnPreRequestHandlerExecute(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPreRequestHandlerExecute");
        }

        public void OnPreSendRequestContent(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPreSendRequestContent");
        }

        public void OnPreSendRequestHeaders(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnPreSendRequestHeaders");
        }

        public void OnReleaseRequestState(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnReleaseRequestState");
        }

        public void OnRequestCompleted(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnRequestCompleted");
        }

        public void OnResolveRequestCache(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnResolveRequestCache");
        }
 
        public void OnUpdateRequestCache(object sender, EventArgs e)
        {
            _log.Debug("MvcApplication.OnUpdateRequestCache");
        }
    }
}
