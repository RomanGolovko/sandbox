using System;
using System.Collections.Generic;
using Garage.DAL.Abstract;
using Garage.DAL.EF;
using Garage.DAL.Entities;

namespace Garage.DAL.Concrete
{
    public class VehiclesRepository : IRepository<Vehicle>
    {
        private EFDbContext db = new EFDbContext();

        public Vehicle GetCurrent(int id)
        {
            return db.Vehicles.Find(id);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return db.Vehicles;
        }

        public void Save(Vehicle vehicle)
        {
            if (vehicle.Id == 0)
                db.Vehicles.Add(vehicle);
            else
            {
                Vehicle dbEntry = db.Vehicles.Find(vehicle.Id);
                if (dbEntry != null)
                {
                    dbEntry.Brand = vehicle.Brand;
                    dbEntry.StateNum = vehicle.StateNum;
                    dbEntry.Color = vehicle.Color;
                    dbEntry.ReleaseDate = vehicle.ReleaseDate;
                    dbEntry.VinCode = vehicle.VinCode;
                    dbEntry.Mileage = vehicle.Mileage;
                    dbEntry.Insurance = vehicle.Insurance;
                    dbEntry.DriverId = vehicle.DriverId;
                }
            }
            db.SaveChanges();
        }

        public Vehicle Delete(int id)
        {
            Vehicle dbEntry = db.Vehicles.Find(id);
            if (dbEntry != null)
            {
                db.Vehicles.Remove(dbEntry);
                db.SaveChanges();
            }
            else
            {
                throw new ApplicationException("Can't delete vehicle with id: " + id);
            }

            return dbEntry;
        }
    }
}
