using log4net;
using log4net.Config;
using Microsoft.Owin;
using Owin;
using System.IO;
using System.Web.Hosting;

[assembly: OwinStartupAttribute(typeof(asp_net_mvc_request_lifecycle.Startup))]
namespace asp_net_mvc_request_lifecycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            

        }
    }
}
