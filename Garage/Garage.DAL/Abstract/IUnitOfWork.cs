using Garage.DAL.Entities;

namespace Garage.DAL.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Driver> Drivers { get; }
        IRepository<Vehicle> Vehicles { get; }
    }
}
