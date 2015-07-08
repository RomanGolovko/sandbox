using Garage.DAL.EF;
using Garage.DAL.Entities;
using Garage.DAL.Interfaces;


namespace Garage.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private GarageContext db;
        private DriverRepository driverRepository;
        private VehicleRepository vehicleRepository;

        /// <summary>
        /// Get instance of data base context
        /// </summary>
        /// <param name="connectionString"></param>
        public EFUnitOfWork(string connectionString)
        {
            db = new GarageContext(connectionString);
        }

        /// <summary>
        /// Get instance of driver repository
        /// </summary>
        public IRepository<Driver> Drivers
        {
            get
            {
                if (driverRepository == null)
                    driverRepository = new DriverRepository(db);

                return driverRepository;
            }
        }

        /// <summary>
        /// Get instance of vehicle repository
        /// </summary>
        public IRepository<Vehicle>Vehicles
        {
            get
            {
                if (vehicleRepository == null)
                    vehicleRepository = new VehicleRepository(db);

                return vehicleRepository;
            }
        }

        /// <summary>
        /// Save changes in data base
        /// </summary>
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
