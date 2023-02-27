using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHubApplication.Startup))]
namespace GigHubApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
