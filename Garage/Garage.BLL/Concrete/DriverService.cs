﻿using System.Collections.Generic;
using AutoMapper;
using Garage.BLL.Abstract;
using Garage.BLL.DTO;
using Garage.BLL.Infrastructure;
using Garage.DAL.Abstract;
using Garage.DAL.Entities;

namespace Garage.BLL.Concrete
{
    public class DriverService : IService<DriverDTO>
    {
        IUnitOfWork db { get; set; }
        public DriverService(IUnitOfWork uow)
        {
            db = uow;
        }

        public DriverDTO GetCurrent(int? id)
        {
            if (id == null)
                throw new ValidationException("Driver id not set", "");

            var driver = db.Drivers.GetCurrent(id.Value);
            if (driver == null)
                throw new ValidationException("Driver not found", "");

            Mapper.CreateMap<Driver, DriverDTO>();
            return Mapper.Map<Driver, DriverDTO>(driver);
        }

        public IEnumerable<DriverDTO> GetAll()
        {
            Mapper.CreateMap<Driver, DriverDTO>();
            return Mapper.Map<IEnumerable<Driver>, List<DriverDTO>>(db.Drivers.GetAll());
        }

        public void Save(DriverDTO item)
        {
            Driver driver = new Driver
            {
                Id = item.Id,
                Name = item.Name,
                BirthDate = item.BirthDate,
                Category = item.Category,
                PhoneNumber = item.PhoneNumber,
                MedicalCertificate = item.MedicalCertificate
            };

            db.Drivers.Save(driver);
        }

        public DriverDTO Delete(int? id)
        {
            if (id == null)
                throw new ValidationException("Driver id not set", "");

            Mapper.CreateMap<Driver, DriverDTO>();
            return Mapper.Map<Driver, DriverDTO>(db.Drivers.Delete(id.Value));
        }
    }
}