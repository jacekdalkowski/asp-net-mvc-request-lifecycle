using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_net_mvc_request_lifecycle.Startup))]
namespace asp_net_mvc_request_lifecycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
