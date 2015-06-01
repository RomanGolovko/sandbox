using System.Data.Entity;
using Garage.Domain;

namespace Garage.Infrastructure
{
    public class GarageContext : DbContext
    {
        public GarageContext() : base("VehicleDepartmentDB")
        { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
