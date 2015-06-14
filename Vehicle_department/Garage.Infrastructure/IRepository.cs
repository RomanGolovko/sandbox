using System;
using System.Linq;
using Garage.Domain;


namespace Garage.Infrastructure
{
    public interface IRepository 
    {
        IQueryable<Driver> Drivers { get; }
        IQueryable<Vehicle> Vehicles { get; }

        /// <summary>
        /// Add driver to DB
        /// </summary>
        /// <param name="driver">Driver</param>
        void CreateDriver(Driver driver);

        /// <summary>
        /// Add vehicle to DB
        /// </summary>
        /// <param name="vehicle">Vehicle</param>
        void CreateVehicle(Vehicle vehicle);

        /// <summary>
        /// Get current driver
        /// </summary>
        /// <param name="id">Drive id</param>
        /// <returns>Current driver</returns>
        Driver GetDriver(Guid id);

        /// <summary>
        /// Get current vehicle
        /// </summary>
        /// <param name="id">Vehicle id</param>
        /// <returns>Current vehicle</returns>
        Vehicle GetVehicle(Guid id);

        /// <summary>
        /// Updates DB
        /// </summary>
        /// <param name="driver">Updated driver</param>
        void UpdateDrivers(Driver driver);

        /// <summary>
        /// Updates DB
        /// </summary>
        /// <param name="vehicle">Updated vehicle</param>
        void UpdateVehicles(Vehicle vehicle);

        /// <summary>
        /// Delete driver from DB
        /// </summary>
        /// <param name="driver">Deleted driver</param>
        void DelDriver(Driver driver);

        /// <summary>
        /// Delete vehicle from DB
        /// </summary>
        /// <param name="vehicle">Deleted vehicle</param>
        void DelVehicle(Vehicle vehicle);
    }
}
