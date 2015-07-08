using System.Collections.Generic;

using Garage.BLL.DTO;

namespace Garage.BLL.Interfaces
{
    public interface IDriverService
    {
        DriverDTO GetDriver(int? id);
        IEnumerable<DriverDTO> GetAllDrivers();
        void AddDriver(DriverDTO driverDTO);
        void EditDriver(int id);
        void RemoveDriver(int id);
    }
}
