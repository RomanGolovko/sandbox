using System.Collections.Generic;

using Garage.BLL.DTO;

namespace Garage.BLL.Interfaces
{
    interface IVehicleService
    {
        VehicleDTO GetVehicle(int? id);
        IEnumerable<VehicleDTO> GetAllVehicles();
        void AddVehicle(VehicleDTO vehicleDTO);
        void EditVehicle(int id);
        void RemoveVehicle(int id);
    }
}
