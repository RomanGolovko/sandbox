using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;
using Garage.Domain;

namespace Garage.Infrastructure.DataLayer.LiteDB
{
    public class LiteDbRepository : IRepository
    {
        LiteDatabase db;

        private LiteDatabase OpenConnecttion()
        {
            db = new LiteDatabase("VehicleDepartmentDB.db");
            return db;
        }
        // drivers enumerator
        public IEnumerable<Driver> DriversList()
        {
            using (db = OpenConnecttion())
            {
                return db.GetCollection<Driver>("Drivers").FindAll().AsEnumerable();
            }
        }
        // vehicle enumerator
        public IEnumerable<Vehicle> VehiclesList()
        {
            using (db = OpenConnecttion())
            {
                return db.GetCollection<Vehicle>("Vehicles").FindAll().AsEnumerable();
            }
        }
        // get current driver
        public Driver GetDriver(Guid id)
        {
            using (db = OpenConnecttion())
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
        }
        // get current vehicle
        public Vehicle GetVehicles(Guid id)
        {
            using (db = OpenConnecttion())
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
        }

        // load drivers entity in DB
        public void LoadDrivers()
        {
        }
        // load vehicles entity in DB
        public void LoadVehicles()
        {
        }
        // bind drivers entity with presentation 
        public List<Driver> BindDrivers()
        {
            using (db = OpenConnecttion())
            {
                List<Driver> driversList = new List<Driver>();
                foreach (var drivers in db.GetCollection<Driver>("Drivers").FindAll())
                    driversList.Add(drivers);
                return driversList;
            }
        }
        //bind vehicles entity with presentation
        public List<Vehicle> BindVehicles()
        {
            using (db = OpenConnecttion())
            {
                List<Vehicle> vehiclesList = new List<Vehicle>();
                foreach (var vehicles in db.GetCollection<Vehicle>("Vehicles").FindAll())
                    vehiclesList.Add(vehicles);
                return vehiclesList;
            }
        }


        // technical service reminder
        public string Reminder()
        {
            using (var db = OpenConnecttion())
            {
                string temp = "";
                var techServ = db.GetCollection<Vehicle>("Vehicles").Find(v => v.NextTechServ < 500);
                foreach (var serv in techServ)
                    temp += serv.Brand + " " + serv.StateNum + " ";

                if (temp.Trim() == "")
                    return null;

                return temp;
            }
        }
        // drivers search
        public List<Driver> DriversSearchedRows(string searchedValue)
        {
            using (db = OpenConnecttion())
            {
                List<Driver> searchedRows = new List<Driver>();
                foreach (var row in db.GetCollection<Driver>("Drivers").Find(d => d.Name.Contains(searchedValue)))
                    searchedRows.Add(row);

                return searchedRows;
            }
        }
        // vehicles search
        public List<Vehicle> VehiclesSearchedRows(string searchedValue)
        {
            if (searchedValue.Trim() == "")
            {

            }
            using (db = OpenConnecttion())
            {
                List<Vehicle> searchedRows = new List<Vehicle>();
                foreach (var row in db.GetCollection<Vehicle>("Vehicles").Find(v => v.Brand.Contains(searchedValue)).Union(
                                    db.GetCollection<Vehicle>("Vehicles").Find(v => v.StateNum.Contains(searchedValue)).Union(
                                    db.GetCollection<Vehicle>("Vehicles").Find(v => v.Color.Contains(searchedValue)).Union(
                                    db.GetCollection<Vehicle>("Vehicles").Find(v => v.VinCode.Contains(searchedValue))))))
                    searchedRows.Add(row);

                return searchedRows;
            }
        }
        // add / edit driver
        public bool AddEditDriver(string name, DateTime birthDate, string category,
            string phoneNum, DateTime medicalCertificate, string id, bool addFlag)
        {
            using (db = OpenConnecttion())
            {
                bool flagResult = false;

                Driver driver = new Driver();
                try
                {
                    driver.Name = name;
                    driver.BirthDate = birthDate;
                    driver.Category = category;
                    driver.PhoneNum = phoneNum;
                    driver.MedicalCertificate = medicalCertificate;
                    driver.Id = Guid.Parse(id);

                    if (addFlag)
                        db.GetCollection<Driver>("Drivers").Insert(driver);
                    else
                        db.GetCollection<Driver>("Drivers").Update(driver);

                    flagResult = true;
                }
                catch (Exception)
                {
                    flagResult = false;
                }

                return flagResult;
            }
        }
        // deleting current driver
        public bool DelDriver(Guid id)
        {
            using (db = OpenConnecttion())
            {
                bool flagResult = false;

                try
                {
                    db.GetCollection<Driver>("Drivers").Delete(d => d.Id == id);
                    flagResult = true;
                }
                catch (Exception)
                {
                    flagResult = false;
                }

                return flagResult;
            }
        }
        // add / edit vehicle
        public bool AddEditVehicle(string brand, string stateNum, string color, DateTime releaseDate,
            string vinCode, string mileage, DateTime insurance, string driverId, string id, bool addFlag)
        {
            using (db = OpenConnecttion())
            {
                bool flagResult = false;

                Vehicle vehicle = new Vehicle();
                try
                {
                    vehicle.Brand = brand;
                    vehicle.StateNum = stateNum;
                    vehicle.Color = color;
                    vehicle.ReleaseDate = releaseDate;
                    vehicle.VinCode = vinCode;
                    vehicle.Mileage = Int32.Parse(mileage);
                    vehicle.Insurance = insurance;
                    vehicle.DriverId = Guid.Parse(driverId);
                    vehicle.Id = Guid.Parse(id);

                    if (addFlag)
                        db.GetCollection<Vehicle>("Vehicles").Insert(vehicle);
                    else
                        db.GetCollection<Vehicle>("Vehicles").Update(vehicle);

                    flagResult = true;
                }
                catch (Exception)
                {
                    flagResult = false;
                }

                return flagResult;
            }
        }
        // deleting current vehicle
        public bool DelVehicle(Guid id)
        {
            using (db = OpenConnecttion())
            {
                bool flagResult = false;

                try
                {
                    db.GetCollection<Vehicle>("Vehicles").Delete(v => v.Id == id);
                    flagResult = true;
                }
                catch (Exception)
                {
                    flagResult = false;
                }

                return flagResult;
            }
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}