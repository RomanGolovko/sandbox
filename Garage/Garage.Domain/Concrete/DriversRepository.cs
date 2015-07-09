using System.Linq;

using Garage.Domain.Abstract;
using Garage.Domain.Entities;

namespace Garage.Domain.Concrete
{
    public class DriversRepository : IRepository<Driver>
    {
        private EFDbContext db = new EFDbContext();

        public IQueryable<Driver> GetAll
        {
            get{ return db.Drivers; }
        }

        public void Save(Driver driver)
        {
            if (driver.Id == 0)
                db.Drivers.Add(driver);
            else
            {
                Driver dbEntry = db.Drivers.Find(driver.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = driver.Name;
                    dbEntry.BirthDate = driver.BirthDate;
                    dbEntry.Category = driver.Category;
                    dbEntry.PhoneNumber = driver.PhoneNumber;
                    dbEntry.MedicalSertificate = driver.MedicalSertificate;
                }
            }
            db.SaveChanges();
        }

        public Driver Delete(int id)
        {
            Driver dbEntry = db.Drivers.Find(id);
            if(dbEntry != null)
            {
                db.Drivers.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }
    }
}
