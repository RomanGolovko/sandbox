using System;
using System.Linq;
using System.Data.Entity;
using Garage.Domain;

namespace Garage.Infrastructure.DataLayer.MSSQL
{
    public class MsSqlRepository : IRepository
    {
        private MsSqlGarageContext db = new MsSqlGarageContext();
        public IQueryable<Driver> Drivers
        {
            get { return db.Drivers; }
        }

        public IQueryable<Vehicle> Vehicles
        {
            get { return db.Vehicles; }
        }
        public void CreateDriver(Driver driver)
        {
            db.Drivers.Add(driver);
            db.SaveChanges();
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
            db.SaveChanges();
        }

        public Driver GetDriver(Guid id)
        {
            return db.Drivers.Find(id);
        }
        public Vehicle GetVehicle(Guid id)
        {
            return db.Vehicles.Find(id);
        }

        public void UpdateDrivers(Driver driver)
        {
            db.Entry(driver).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void UpdateVehicles(Vehicle vehicle)
        {
            db.Entry(vehicle).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DelDriver(Driver driver)
        {
            db.Drivers.Remove(driver);
            db.SaveChanges();
        }
        public void DelVehicle(Vehicle vehicle)
        {
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
        }
    }
}
