using System;
using System.Collections.Generic;

using Garage.Domain;

namespace Garage.Infrastructure
{
    public interface IRepository : IDisposable
    {
        /// <summary>
        /// driver enumerator
        /// </summary>
        /// <returns >collection of drivers</returns>
        IEnumerable<Driver> DriversList();
        /// <summary>
        /// vehicle enumerator
        /// </summary>
        /// <returns>collection of vehicles</returns>
        IEnumerable<Vehicle> VehiclesList();
        /// <summary>
        /// get current driver
        /// </summary>
        /// <param name="id">current driver id</param>
        /// <returns>current driver</returns>
        Driver GetDriver(Guid id);
        /// <summary>
        /// get current vehicle
        /// </summary>
        /// <param name="id">current vehicle id</param>
        /// <returns>current vehicle</returns>
        Vehicle GetVehicles(Guid id);

        /// <summary>
        /// load drivers entity in DB
        /// </summary>
        void LoadDrivers();
        /// <summary>
        /// load vehicles entity in DB
        /// </summary>
        void LoadVehicles();
        /// <summary>
        /// bind drivers entity with presentation
        /// </summary>
        /// <returns>binded drivers collection</returns>
        List<Driver> BindDrivers();
        /// <summary>
        /// bind vehicles entity with presentation
        /// </summary>
        /// <returns>binded vehicles collection</returns>
        List<Vehicle> BindVehicles();

        /// <summary>
        /// technical service reminder
        /// </summary>
        /// <returns>car brand and state number</returns>
        string Reminder();
        /// <summary>
        /// drivers search
        /// </summary>
        /// <param name="searchedValue">searched value</param>
        /// <returns>searched rows</returns>
        List<Driver> DriversSearchedRows(string searchedValue);
        /// <summary>
        /// vehicles search
        /// </summary>
        /// <param name="searchedValue">searched value</param>
        /// <returns>searched rows</returns>
        List<Vehicle> VehiclesSearchedRows(string searchedValue);
        /// <summary>
        /// add / edit driver
        /// </summary>
        /// <param name="name">drivers name</param>
        /// <param name="birthDate">drivers date of birth</param>
        /// <param name="category">drivers category</param>
        /// <param name="phoneNum">drivers phone number</param>
        /// <param name="medicalCertificate">medical certificate expire date</param>
        /// <param name="id">drivers id </param>
        /// <param name="addFlag">flag of the add(true) or edit(false)</param>
        /// <returns>operation status</returns>
        bool AddEditDriver(string name, DateTime birthDate, string category,
            string phoneNum, DateTime medicalCertificate, string id, bool addFlag);
        /// <summary>
        /// delete driver
        /// </summary>
        /// <param name="id">deleting driver id</param>
        /// <returns>operation status</returns>
        bool DelDriver(Guid id);
        /// <summary>
        /// add / delete vehicle
        /// </summary>
        /// <param name="brand">vehicle brand</param>
        /// <param name="stateNum">vehicle state number</param>
        /// <param name="color">vehicle color</param>
        /// <param name="releaseDate">vehicle release date</param>
        /// <param name="vinCode">vehicle VIN code</param>
        /// <param name="mileage">vehicle mileage</param>
        /// <param name="insurance">insurance expire date</param>
        /// <param name="driverId">drivers id</param>
        /// <param name="id">vehicle id</param>
        /// <param name="addFlag">flag of the add(true) or edit(false)</param>
        /// <returns>operation status</returns>
        bool AddEditVehicle(string brand, string stateNum, string color,
            DateTime releaseDate, string vinCode, string mileage, DateTime insurance,
            string driverId, string id, bool addFlag);
        /// <summary>
        /// delete vehicle
        /// </summary>
        /// <param name="id">deleting vehicle id</param>
        /// <returns>operation status</returns>
        bool DelVehicle(Guid id);
    }
}
