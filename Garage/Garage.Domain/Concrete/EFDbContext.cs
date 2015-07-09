using System.Data.Entity;

using Garage.Domain.Entities;

namespace Garage.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public EFDbContext() : base("GarageDB")
        {}

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
