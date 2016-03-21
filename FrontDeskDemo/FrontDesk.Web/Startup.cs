using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontDesk.Web.Startup))]
namespace FrontDesk.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
