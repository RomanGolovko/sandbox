using System.Collections.Generic;

using ExpressMapper;

using Garage.DAL.Entities;
using Garage.DAL.Interfaces;
using Garage.BLL.DTO;
using Garage.BLL.Interfaces;
using Garage.BLL.Infrastructure;

namespace Garage.BLL.Services
{
    public class DriverService : IDriverService
    {
        IUnitOfWork DataBase { get; set; }
        public DriverService(IUnitOfWork uow)
        {
            DataBase = uow;
        }

        public DriverDTO GetDriver(int? id)
        {
            if (id == null)
                throw new ValidationException("Drivers id not set", "");

            var driver = DataBase.Drivers.Get(id.Value);
            if (driver == null)
                throw new ValidationException("Driver not found", "");

            return Mapper.Map<Driver, DriverDTO>(driver);
        }

        public IEnumerable<DriverDTO> GetAllDrivers()
        {
            Mapper.Register<Driver, DriverDTO>();
            return Mapper.Map<IEnumerable<Driver>, List<DriverDTO>>(DataBase.Drivers.GetAll());
        }

        public void AddDriver(DriverDTO driverDTO)
        {
            Driver driver = new Driver
            {
                Id = driverDTO.Id,
                Name = driverDTO.Name,
                BirthDate = driverDTO.BirthDate,
                Category = driverDTO.Category,
                PhoneNumber = driverDTO.PhoneNumber,
                MedicalSertificate = driverDTO.MedicalSertificate
            };
            DataBase.Drivers.Create(driver);
            DataBase.Save();
        }

        public void EditDriver(int id)
        {
            if (id <= 0)
                throw new ValidationException("Drivers id not set", "");

            var driver = DataBase.Drivers.Get(id);
            if (driver == null)
                throw new ValidationException("Driver not found", "");

            DataBase.Drivers.Update(driver);
            DataBase.Save();
        }

        public void RemoveDriver(int id)
        {
            DataBase.Drivers.Delete(id);
            DataBase.Save();
        }
    }
}
