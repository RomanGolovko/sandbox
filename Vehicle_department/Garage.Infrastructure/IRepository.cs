using System;
using System.Collections.Generic;
using Garage.Domain;
using System.ComponentModel;

namespace Garage.Infrastructure
{
    public interface IRepository
    {
        IEnumerable<Driver> DriversList();
        IEnumerable<Vehicle> VehiclesList();
        Driver GetDriver(Guid id);
        Vehicle GetVehicles(Guid id);

        void LoadDrivers();
        void LoadVehicles();
        BindingList<Driver> BindDrivers();
        BindingList<Vehicle> BindVehicles();

        void Reminder();
        List<Driver> DriversSearchedRows(string searchedValue);
        List<Vehicle> VehiclesSearchedRows(string searchedValue);
        bool AddEditDriver(string name, DateTime birthDate, string category,
            string phoneNum, DateTime medicalCertificate, string id, bool addFlag);
        bool DelDriver(Guid id);
        bool AddEditVehicle(string brand, string stateNum, string color,
            DateTime releaseDate, string vinCode, string mileage, DateTime insurance,
            string driverId, string id, bool addFlag);
        bool DelVehicle(Guid id);
    }
}
