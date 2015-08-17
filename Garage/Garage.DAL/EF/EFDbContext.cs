using System.Data.Entity;
using Garage.DAL.Entities;

namespace Garage.DAL.EF
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("GarageDB")
        { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
