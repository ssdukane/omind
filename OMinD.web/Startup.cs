using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OMinD.web.Startup))]
namespace OMinD.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
