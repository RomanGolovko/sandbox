using System;
using System.Collections.Generic;
using Garage.Domain;
using System.ComponentModel;

namespace Garage.Infrastructure
{
    public interface IRepository
    {
        // drivers enumerator
        IEnumerable<Driver> DriversList();
        // vehicle enumerator
        IEnumerable<Vehicle> VehiclesList();
        // current driver accessor
        Driver GetDriver(Guid id);
        // current vehicle accessor
        Vehicle GetVehicles(Guid id);

        // load drivers entity in DB
        void LoadDrivers();
        // load vehicles entity in DB
        void LoadVehicles();
        BindingList<Driver> BindDrivers();
        BindingList<Vehicle> BindVehicles();

        // remind about technical service
        void Reminder();


        /// <summary>
        /// Drivers search
        /// </summary>
        /// <returns>The searched rows.</returns>
        /// <param name="searchedValue">Searched value.</param>
        List<Driver> DriversSearchedRows(string searchedValue);
        // search vehicle
        List<Vehicle> VehiclesSearchedRows(string searchedValue);
        // add / edit driver
        bool AddEditDriver(string name, DateTime birthDate, string category,
            string phoneNum, DateTime medicalCertificate, string id, bool addFlag);
        // delete driver
        bool DelDriver(Guid id);
        // add / delete vehicle
        bool AddEditVehicle(string brand, string stateNum, string color,
            DateTime releaseDate, string vinCode, string mileage, DateTime insurance,
            string driverId, string id, bool addFlag);
        // delete vehicle
        bool DelVehicle(Guid id);
    }
}
