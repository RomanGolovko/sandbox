using System;

namespace Garage.DAL.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string StateNum { get; set; }
        public string Color { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string VinCode { get; set; }
        public int Mileage { get; set; }
        public DateTime Insurance { get; set; }

        public int? DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
