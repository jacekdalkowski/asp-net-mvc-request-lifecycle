using asp_net_mvc_request_lifecycle.Controllers;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_net_mvc_request_lifecycle.Infrastructure
{
    public class VerboseDependencyResolver : IDependencyResolver
    {
        private ILog _log = LogManager.GetLogger(typeof(VerboseDependencyResolver));

        public object GetService(Type serviceType)
        {
            _log.Debug("VerboseDependencyResolver.GetService(Type serviceType), serviceType: " + serviceType.ToString());

            if(serviceType.Equals(typeof(IControllerFactory)))
            {
                // Cannot return controller here, as it is also set via
                // ControllerBuilder.Current.SetControllerFactory.
                //return new VerboseControllerFactory();
                _log.Debug("VerboseDependencyResolver.GetService(Type serviceType) returning null.");
                return null; 
            }

            if (serviceType.Equals(typeof(IControllerActivator)))
            {
                _log.Debug("VerboseDependencyResolver.GetService(Type serviceType) returning null.");
                return null;
            }

            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                _log.Debug("VerboseDependencyResolver.GetService(Type serviceType) returning instance of HomeController.");
                return new HomeController();
            }

            _log.Debug("VerboseDependencyResolver.GetService(Type serviceType) returning null.");
            return null;
        }


        public IEnumerable<object> GetServices(Type serviceType)
        {
            _log.Debug("VerboseDependencyResolver.GetServices(Type serviceType), serviceType: " + serviceType);
            _log.Debug("VerboseDependencyResolver.GetServices(Type serviceType), returning an empty array.");
            return new object[0];
        }
    }
}