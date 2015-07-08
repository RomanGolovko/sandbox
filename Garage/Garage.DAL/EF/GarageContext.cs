using System;

using System.Data.Entity;

using Garage.DAL.Entities;

namespace Garage.DAL.EF
{
    public class GarageContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        static GarageContext()
        {
            Database.SetInitializer<GarageContext>(new GarageDbInitializer());
        }
        public GarageContext(string connectionString) : base(connectionString)
        { }
    }

    /// <summary>
    /// Temporary stub
    /// </summary>
    public class GarageDbInitializer : DropCreateDatabaseIfModelChanges<GarageContext>
    {
        protected override void Seed(GarageContext db)
        {
            db.Drivers.Add(new Driver
            {
                Id = 1,
                Name = "Ivanov Ivan",
                BirthDate = DateTime.Parse("8.6.1969"),
                Category = "B",
                PhoneNumber = "(050) 526-78-95",
                MedicalSertificate = DateTime.Parse("1.12.2015")
            });
            db.SaveChanges();
        }
    }
}
