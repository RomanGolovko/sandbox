using System.Collections.Generic;

using System.Data.Entity;

using Garage.DAL.EF;
using Garage.DAL.Entities;
using Garage.DAL.Interfaces;

namespace Garage.DAL.Repositories
{
    public class DriverRepository : IRepository<Driver>
    {
        private GarageContext db;
        public DriverRepository(GarageContext context)
        {
            this.db = context;
        }
        /// <summary>
        /// Get all drivers from data base
        /// </summary>
        /// <returns>Drivers collection</returns>
        public IEnumerable<Driver> GetAll()
        {
            return db.Drivers;
        }

        /// <summary>
        /// Get current driver via id
        /// </summary>
        /// <param name="id">Driver id</param>
        /// <returns>Current driver</returns>
        public Driver Get(int id)
        {
            return db.Drivers.Find(id);
        }

        /// <summary>
        /// Add driver to data base
        /// </summary>
        /// <param name="driver">Driver item</param>
        public void Create(Driver driver)
        {
            db.Drivers.Add(driver);
        }

        /// <summary>
        /// Edit driver
        /// </summary>
        /// <param name="driver">Driver item</param>
        public void Update(Driver driver)
        {
            db.Entry(driver).State = EntityState.Modified;
        }

        /// <summary>
        /// Remove driver from data base
        /// </summary>
        /// <param name="id">Driver id</param>
        public void Delete(int id)
        {
            Driver driver = db.Drivers.Find(id);
            if (driver != null)
                db.Drivers.Remove(driver);
        }
    }
}
