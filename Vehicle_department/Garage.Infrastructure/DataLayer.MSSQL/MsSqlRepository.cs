using System;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Entity;
using Garage.Domain;

namespace Garage.Infrastructure.DataLayer.MSSQL
{
    public class MsSqlRepository : IRepository
    {
        private GarageContext db = new GarageContext();

        // drivers enumerator
        public IEnumerable<Driver> DriversList()
        {
            return db.Drivers;
        }
        // vehicle enumerator
        public IEnumerable<Vehicle> VehiclesList()
        {
            return db.Vehicles;
        }
        // get current driver
        public Driver GetDriver(Guid id)
        {
            return db.Drivers.Find(id);
        }
        // get current vehicle
        public Vehicle GetVehicles(Guid id)
        {
            return db.Vehicles.Find(id);
        }
        
        // load drivers entity in DB
        public void LoadDrivers()
        {
            db.Drivers.Load();
        }
        // load vehicles entity in DB
        public void LoadVehicles()
        {
            db.Vehicles.Load();
        }
        // bind drivers entity with presentation 
        public List<Driver> BindDrivers()
        {
            return db.Drivers.Local.ToBindingList().ToList<Driver>();
        }
        //bind vehicles entity with presentation
        public List<Vehicle> BindVehicles()
        {
            return db.Vehicles.Local.ToBindingList().ToList<Vehicle>();
        }


        // technical service reminder
        public string Reminder()
        {
            string temp = "";
            var techServ = db.Vehicles.Where(x => x.NextTechServ < 500);
            foreach (Vehicle serv in techServ)
                temp += serv.Brand + " " + serv.StateNum + " ";

            if (temp.Trim() == "")
                return null;

            return temp;
        }
        // drivers search
        public List<Driver> DriversSearchedRows(string searchedValue)
        {
            List<Driver> searchedRows = new List<Driver>();
            foreach (var row in db.Drivers.Where(d => d.Name.Contains(searchedValue)))
                searchedRows.Add(row);

            return searchedRows;
        }
        // vehicles search
        public List<Vehicle> VehiclesSearchedRows(string searchedValue)
        {
            List<Vehicle> searchedRows = new List<Vehicle>();
            foreach (var row in db.Vehicles.Where(v => v.Brand.Contains(searchedValue)).Union(
                                db.Vehicles.Where(v => v.StateNum.Contains(searchedValue)).Union(
                                db.Vehicles.Where(v => v.Color.Contains(searchedValue)).Union(
                                db.Vehicles.Where(v => v.VinCode.Contains(searchedValue))))))
                searchedRows.Add(row);

            return searchedRows;
        }
        // add / edit driver
        public bool AddEditDriver(string name, DateTime birthDate, string category, 
            string phoneNum, DateTime medicalCertificate, string id, bool addFlag)
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
                    db.Drivers.Add(driver);
                else
                    db.Entry(driver).State = EntityState.Modified;

                db.SaveChanges();

                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
        }
        // deleting current driver
        public bool DelDriver(Guid id)
        {
            bool flagResult = false;

            var driver = GetDriver(id);

            try
            {
                db.Drivers.Remove(driver);
                db.SaveChanges();
                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
        }
        // add / edit vehicle
        public bool AddEditVehicle(string brand, string stateNum, string color, DateTime releaseDate,
            string vinCode, string mileage, DateTime insurance, string driverId, string id, bool addFlag)
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
                    db.Vehicles.Add(vehicle);
                else
                    db.Entry(vehicle).State = EntityState.Modified;

                db.SaveChanges();

                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
        }
        // deleting current vehicle
        public bool DelVehicle(Guid id)
        {
            bool flagResult = false;

            var vehicle = GetVehicles(id);

            try
            {
                db.Vehicles.Remove(vehicle);
                db.SaveChanges();
                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
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
