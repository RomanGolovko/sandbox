using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Ninject;
using Garage.Domain;

namespace Garage.Infrastructure
{
    public class GarageContoller
    {
        IRepository repository;
        public GarageContoller(IRepository repo)
        {
            repository = repo;
        }
        public GarageContoller(bool LiteDb, bool MsSql)
        {
            IKernel ninjectKernel = new StandardKernel(new ConfigModule(LiteDb, MsSql));
            repository = ninjectKernel.Get<IRepository>();
        }

        /// <summary>
        /// Load drivers entityes from DB (EF only)
        /// </summary>
        public void LoadDrivers()
        {
            repository.Drivers.Load();
        }
        /// <summary>
        /// Load vehicles entityes from DB (EF only)
        /// </summary>
        public void LoadVehicles()
        {
            repository.Vehicles.Load();
        }

        /// <summary>
        /// Bind drivers entity with presentation 
        /// </summary>
        /// <returns>List of drivers</returns>
        public List<Driver> BindDrivers()
        {
            return repository.Drivers.ToList();
        }
        /// <summary>
        /// Bind vehicles entity with presentation
        /// </summary>
        /// <returns>List of vehicles</returns>
        public List<Vehicle> BindVehicles()
        {
            return repository.Vehicles.ToList();
        }

        /// <summary>
        /// Get current driver via id
        /// </summary>
        /// <param name="id">Current driver id</param>
        /// <returns>Current driver</returns>
        public Driver GetDriver(Guid id)
        {
            return repository.GetDriver(id);
        }
        /// <summary>
        /// Get current vehicle via id
        /// </summary>
        /// <param name="id">Current vehicle id</param>
        /// <returns>Current vehicle</returns>
        public Vehicle GetVehicle(Guid id)
        {
            return repository.GetVehicle(id);
        }

        /// <summary>
        /// Remind about soon technical service 
        /// </summary>
        /// <returns></returns>
        public string Reminder()
        {
            string temp = "";
            var techServ = repository.Vehicles.Where(x => x.NextTechServ < 500);
            foreach (Vehicle serv in techServ)
                temp += serv.Brand + " " + serv.StateNum + " ";

            if (temp.Trim() == "")
                return null;

            return temp;
        }

        /// <summary>
        /// Search driver
        /// </summary>
        /// <param name="searchedValue">The value to search for</param>
        /// <returns>The list of found drivers</returns>
        public List<Driver> DriversSearchedRows(string searchedValue)
        {
            List<Driver> searchedRows = new List<Driver>();
            foreach (var row in repository.Drivers.Where(d => d.Name.Contains(searchedValue)))
                searchedRows.Add(row);

            return searchedRows;
        }
        /// <summary>
        /// Search vehicle
        /// </summary>
        /// <param name="searchedValue">The value to search for</param>
        /// <returns>The list of found vehicles</returns>
        public List<Vehicle> VehiclesSearchedRows(string searchedValue)
        {
            List<Vehicle> searchedRows = new List<Vehicle>();
            foreach (var row in repository.Vehicles.Where(v => v.Brand.Contains(searchedValue)).Union(
                                repository.Vehicles.Where(v => v.StateNum.Contains(searchedValue)).Union(
                                repository.Vehicles.Where(v => v.Color.Contains(searchedValue)).Union(
                                repository.Vehicles.Where(v => v.VinCode.Contains(searchedValue))))))
                searchedRows.Add(row);

            return searchedRows;
        }

        /// <summary>
        /// Upsert driver
        /// </summary>
        /// <param name="name">Driver name</param>
        /// <param name="birthDate">Driver date of birth</param>
        /// <param name="category">Drivers category</param>
        /// <param name="phoneNum">Drivers phone number</param>
        /// <param name="medicalCertificate">Drivers medical sertificate best before</param>
        /// <param name="id"> Drivers id</param>
        /// <param name="addFlag">Add flag</param>
        /// <returns>Operation state</returns>
        public bool UpsertDriver(string name, DateTime birthDate, string category,
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
                    repository.CreateDriver(driver);
                else
                    repository.UpdateDrivers(driver);

                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
        }
        /// <summary>
        /// Upsert vehicle
        /// </summary>
        /// <param name="brand">Vehicle brand</param>
        /// <param name="stateNum">Vehicle state number</param>
        /// <param name="color">Vehicle color</param>
        /// <param name="releaseDate">Vehicle release date</param>
        /// <param name="vinCode">Vehicle VIN code</param>
        /// <param name="mileage">Vehicle mileage</param>
        /// <param name="insurance">Vehicle insurance best before</param>
        /// <param name="driverId">Driver id</param>
        /// <param name="id">Vehicle id</param>
        /// <param name="addFlag">Add flag</param>
        /// <returns>Operation state</returns>
        public bool UpsertVehicle(string brand, string stateNum, string color, DateTime releaseDate,
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
                    repository.CreateVehicle(vehicle);
                else
                    repository.UpdateVehicles(vehicle);

                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
        }

        /// <summary>
        /// Remove current driver
        /// </summary>
        /// <param name="id">Driver id</param>
        /// <returns>Operation state</returns>
        public bool RemoveDriver(Guid id)
        {
            bool flagResult = false;

            var driver = GetDriver(id);

            try
            {
                repository.DelDriver(driver);
                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
        }

        /// <summary>
        /// Delete current vehicle
        /// </summary>
        /// <param name="id">Vehicle id</param>
        /// <returns>Operation state</returns>
        public bool RemoveVehicle(Guid id)
        {
            bool flagResult = false;

            var vehicle = GetVehicle(id);

            try
            {
                repository.DelVehicle(vehicle);
                flagResult = true;
            }
            catch (Exception)
            {
                flagResult = false;
            }

            return flagResult;
        }
    }
}
