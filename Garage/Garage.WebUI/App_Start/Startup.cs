using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

using Garage.WebUI.Models;

[assembly: OwinStartup(typeof(Garage.WebUI.App_Start.Startup))]

namespace Garage.WebUI.App_Start
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<EFAuthContext>(EFAuthContext.Create);
            app.CreatePerOwinContext<GarageUserManager>(GarageUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}
