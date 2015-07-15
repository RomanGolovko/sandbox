using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Garage.WebUI.Models
{
    public class EFAuthContext : IdentityDbContext<GarageUser>
    {
        public EFAuthContext() : base("IdentityDb"){ }
        public static EFAuthContext Create()
        {
            return new EFAuthContext();
        }
    }
}
