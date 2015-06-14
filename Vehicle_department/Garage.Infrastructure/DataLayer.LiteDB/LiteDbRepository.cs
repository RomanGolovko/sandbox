using System;
using System.Linq;
using LiteDB;
using Garage.Domain;

namespace Garage.Infrastructure.DataLayer.LiteDB
{
    public class LiteDbRepository : IRepository
    {
        LiteDatabase db = new LiteDatabase("VehicleDepartmentDB.db");

        public IQueryable<Driver> Drivers
        {
            get
            {
                return db.GetCollection<Driver>("Drivers").FindAll().AsQueryable();
            }
        }

        public IQueryable<Vehicle> Vehicles
        {
            get
            {
                return db.GetCollection<Vehicle>("Vehicles").FindAll().AsQueryable();
            }
        }

        public void CreateDriver(Driver driver)
        {
            db.GetCollection<Driver>("Drivers").Insert(driver);
        }
        public void CreateVehicle(Vehicle vehicle)
        {
            db.GetCollection<Vehicle>("Vehicles").Insert(vehicle);
        }

        public Driver GetDriver(Guid id)
        {
            Driver driver = new Driver();
            foreach (var item in db.GetCollection<Driver>("Drivers").Find(d => d.Id == id))
            {
                driver.Id = item.Id;
                driver.Name = item.Name;
                driver.BirthDate = item.BirthDate;
                driver.Category = item.Category;
                driver.PhoneNum = item.PhoneNum;
                driver.MedicalCertificate = item.MedicalCertificate;
            }
            return driver;
        }
        public Vehicle GetVehicle(Guid id)
        {
            Vehicle vehicle = new Vehicle();
            foreach (var item in db.GetCollection<Vehicle>("Vehicles").Find(d => d.Id == id))
            {
                vehicle.Id = item.Id;
                vehicle.Brand = item.Brand;
                vehicle.StateNum = item.StateNum;
                vehicle.Color = item.Color;
                vehicle.ReleaseDate = item.ReleaseDate;
                vehicle.VinCode = item.VinCode;
                vehicle.Mileage = item.Mileage;
                vehicle.Insurance = item.Insurance;
                vehicle.NextTechServ = item.NextTechServ;
                vehicle.DriverId = item.DriverId;
            }
            return vehicle;
        }

        public void UpdateDrivers(Driver driver)
        {
            db.GetCollection<Driver>("Drivers").Update(driver);
        }
        public void UpdateVehicles(Vehicle vehicle)
        {
            db.GetCollection<Vehicle>("Vehicles").Update(vehicle);
        }

        public void DelDriver(Driver driver)
        {
            db.GetCollection<Driver>("Drivers").Delete(d => d.Id == driver.Id);
        }
        public void DelVehicle(Vehicle vehicle)
        {
            db.GetCollection<Vehicle>("Vehicle").Delete(v => v.Id == vehicle.Id);
        }
    }
}