using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace Garage.WebUI.Models
{
    public class GarageUserManager : UserManager<GarageUser>
    {
        public GarageUserManager(IUserStore<GarageUser> store) : base(store)
        {
        }

        public static GarageUserManager Create(IdentityFactoryOptions<GarageUserManager> options, IOwinContext context)
        {
            EFAuthContext db = context.Get<EFAuthContext>();
            GarageUserManager manager = new GarageUserManager(new UserStore<GarageUser>(db));
            return manager;
        }
    }
}
