using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Garage.WebUI.Startup))]
namespace Garage.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
