using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FireAndExplosionHazards.UI.Startup))]
namespace FireAndExplosionHazards.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
