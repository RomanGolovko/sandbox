using System.Collections.Generic;

using System.Data.Entity;

using Garage.DAL.EF;
using Garage.DAL.Entities;
using Garage.DAL.Interfaces;

namespace Garage.DAL.Repositories
{
    public class VehicleRepository : IRepository<Vehicle>
    {
        private GarageContext db;
        public VehicleRepository(GarageContext context)
        {
            this.db = context;
        }
        /// <summary>
        /// Get all vehicles from data base
        /// </summary>
        /// <returns>Vehicles collection</returns>
        public IEnumerable<Vehicle> GetAll()
        {
            return db.Vehicles;
        }

        /// <summary>
        /// Get current vehicle via id
        /// </summary>
        /// <param name="id">Vehicle id</param>
        /// <returns>Current vehicle</returns>
        public Vehicle Get(int id)
        {
            return db.Vehicles.Find(id);
        }

        /// <summary>
        /// Add vehicle to data base
        /// </summary>
        /// <param name="vehicle">Vehicle item</param>
        public void Create(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
        }

        /// <summary>
        /// Edit vehicle
        /// </summary>
        /// <param name="vehicle">Vehicle item</param>
        public void Update(Vehicle vehicle)
        {
            db.Entry(vehicle).State = EntityState.Modified;
        }

        /// <summary>
        /// Remove vehicle from data base
        /// </summary>
        /// <param name="id">Vehicle id</param>
        public void Delete(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle != null)
                db.Vehicles.Remove(vehicle);
        }
    }
}
