using System.Collections.Generic;

using ExpressMapper;

using Garage.DAL.Entities;
using Garage.DAL.Interfaces;
using Garage.BLL.DTO;
using Garage.BLL.Interfaces;
using Garage.BLL.Infrastructure;

namespace Garage.BLL.Services
{
    class VehicleService : IVehicleService
    {
        IUnitOfWork DataBase { get; set; }
        public VehicleService(IUnitOfWork uow)
        {
            DataBase = uow;
        }

        public VehicleDTO GetVehicle(int? id)
        {
            if (id == null)
                throw new ValidationException("Vehicle id not set", "");

            var vehicle = DataBase.Vehicles.Get(id.Value);
            if (vehicle == null)
                throw new ValidationException("Vehicle not found", "");

            return Mapper.Map<Vehicle, VehicleDTO>(vehicle);
        }

        public IEnumerable<VehicleDTO> GetAllVehicles()
        {
            Mapper.Register<Vehicle, VehicleDTO>();
            return Mapper.Map<IEnumerable<Vehicle>,List<VehicleDTO>>(DataBase.Vehicles.GetAll());
        }

        public void AddVehicle(VehicleDTO vehicleDTO)
        {
            Vehicle vehicle = new Vehicle
            {
                Id = vehicleDTO.Id,
                Brand = vehicleDTO.Brand,
                StateNumber = vehicleDTO.StateNumber,
                ReleaseDate = vehicleDTO.ReleaseDate,
                Color = vehicleDTO.Color,
                Mileage = vehicleDTO.Mileage,
                Insurance = vehicleDTO.Insurance,
                DriverId = vehicleDTO.DriverId,
            };

            DataBase.Vehicles.Create(vehicle);
            DataBase.Save();
        }

        public void EditVehicle(int id)
        {
            if (id <= 0)
                throw new ValidationException("Vehicle id not set", "");

            var vehicle = DataBase.Vehicles.Get(id);
            if(vehicle == null)
                throw new ValidationException("Vehicle not found", "");

            DataBase.Vehicles.Update(vehicle);
            DataBase.Save();
        }

        public void RemoveVehicle(int id)
        {
            if (id <= 0)
                throw new ValidationException("Vehicle id not set", "");

            DataBase.Vehicles.Delete(id);
            DataBase.Save();
        }
    }
}
