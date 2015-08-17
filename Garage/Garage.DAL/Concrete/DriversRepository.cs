using System;
using System.Collections.Generic;
using Garage.DAL.Abstract;
using Garage.DAL.EF;
using Garage.DAL.Entities;

namespace Garage.DAL.Concrete
{
    public class DriversRepository : IRepository<Driver>
    {
        private EFDbContext db = new EFDbContext();

        public Driver GetCurrent(int id)
        {
            return db.Drivers.Find(id);
        }

        public IEnumerable<Driver> GetAll()
        {
            return db.Drivers;
        }

        public void Save(Driver driver)
        {
            if (driver.Id == 0)
            {
                db.Drivers.Add(driver);
            }
            else
            {
                Driver dbEntry = db.Drivers.Find(driver.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = driver.Name;
                    dbEntry.BirthDate = driver.BirthDate;
                    dbEntry.Category = driver.Category;
                    dbEntry.PhoneNumber = driver.PhoneNumber;
                    dbEntry.MedicalCertificate = driver.MedicalCertificate;
                }
            }
            db.SaveChanges();
        }

        public Driver Delete(int id)
        {
            Driver dbEntry = db.Drivers.Find(id);
            if (dbEntry != null)
            {
                db.Drivers.Remove(dbEntry);
                db.SaveChanges();
            }
            else
            {
                throw new ApplicationException("Can't delete driver with id:" + id);
            }

            return dbEntry;
        }
    }
}
