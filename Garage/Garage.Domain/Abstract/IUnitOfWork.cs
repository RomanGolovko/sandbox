using Garage.Domain.Entities;

namespace Garage.Domain.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Driver> Drivers { get; }
        IRepository<Vehicle> Vehicles { get; }
    }
}
