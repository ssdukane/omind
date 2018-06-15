using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OMinds.web.Startup))]
namespace OMinds.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
