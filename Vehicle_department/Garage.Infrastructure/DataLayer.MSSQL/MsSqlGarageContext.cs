using System.Data.Entity;
using Garage.Domain;

namespace Garage.Infrastructure.DataLayer.MSSQL
{
    public class MsSqlGarageContext : DbContext
    {
        public MsSqlGarageContext() : base("VehicleDepartmentDB")
        { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
