using Garage.DAL.Abstract;
using Garage.DAL.EF;
using Garage.DAL.Entities;

namespace Garage.DAL.Concrete
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private EFDbContext db = new EFDbContext();
        private DriversRepository driversRepository;
        private VehiclesRepository vehiclesRepository;

        public IRepository<Driver> Drivers
        {
            get
            {
                if (driversRepository == null)
                    driversRepository = new DriversRepository();

                return driversRepository;
            }
        }

        public IRepository<Vehicle> Vehicles
        {
            get
            {
                if (vehiclesRepository == null)
                    vehiclesRepository = new VehiclesRepository();

                return vehiclesRepository;
            }
        }
    }
}
