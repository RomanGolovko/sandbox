using Garage.DAL.Entities;

namespace Garage.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Get instance of driver repository
        /// </summary>
        IRepository<Driver> Drivers { get; }

        /// <summary>
        /// Get instance of vehicle repository
        /// </summary>
        IRepository<Vehicle> Vehicles { get; }

        /// <summary>
        /// Save changes in data base
        /// </summary>
        void Save();
    }
}
