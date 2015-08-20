using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Garage.BLL.Abstract;
using Garage.BLL.DTO;
using Garage.BLL.Infrastructure;
using Garage.DAL.Abstract;
using Garage.DAL.Entities;

namespace Garage.BLL.Concrete
{
    public class VehicleService : IService<VehicleDTO>
    {
        IUnitOfWork db { get; set; }

        public VehicleService(IUnitOfWork uow)
        {
            db = uow;
        }

        public VehicleDTO GetCurrent(int? id)
        {
            var vehicle = db.Vehicles.GetCurrent(id.Value);
            if (vehicle == null)
                throw new ValidationException("Vehicle not found", "");

            Mapper.CreateMap<Vehicle, VehicleDTO>();
            return Mapper.Map<Vehicle, VehicleDTO>(vehicle);
        }

        public IEnumerable<VehicleDTO> GetAll()
        {
            Mapper.CreateMap<Vehicle, VehicleDTO>();
            return Mapper.Map<IEnumerable<Vehicle>, List<VehicleDTO>>(db.Vehicles.GetAll());
        }

        public IEnumerable<VehicleDTO> Search(string str)
        {
            Mapper.CreateMap<Vehicle, VehicleDTO>();
            var vehicles = Mapper.Map<IEnumerable<Vehicle>, List<VehicleDTO>>(db.Vehicles.GetAll());

            if (string.IsNullOrEmpty(str))
            {
                return vehicles;
            }
            else
            {
                List<VehicleDTO> vehiclesList = new List<VehicleDTO>();

                foreach (var item in vehicles.Where(v => v.Brand.ToLower().Contains(str.ToLower())).Union(
                                     vehicles.Where(v => v.StateNum.ToLower().Contains(str.ToLower())).Union(
                                     vehicles.Where(v => v.Color.ToLower().Contains(str.ToLower())).Union(
                                     vehicles.Where(v => v.VinCode.ToLower().Contains(str.ToLower()))))))
                {
                    vehiclesList.Add(item);
                }

                return vehiclesList;
            }
        }
        public void Save(VehicleDTO item)
        {
            Vehicle vehicle = new Vehicle
            {
                Id = item.Id,
                Brand = item.Brand,
                StateNum = item.StateNum,
                Color = item.Color,
                ReleaseDate = item.ReleaseDate,
                VinCode = item.VinCode,
                Mileage = item.Mileage,
                Insurance = item.Insurance,
                DriverId = item.DriverId
            };

            db.Vehicles.Save(vehicle);
        }

        public VehicleDTO Delete(int? id)
        {
            if (id == null)
                throw new ValidationException("Vehicle id not set", "");

            Mapper.CreateMap<Vehicle, VehicleDTO>();
            return Mapper.Map<Vehicle, VehicleDTO>(db.Vehicles.Delete(id.Value));
        }
    }
}
