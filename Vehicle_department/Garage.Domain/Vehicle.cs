using System;

namespace Garage.Domain
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string StateNum { get; set; }
        public string Color { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string VinCode { get; set; }
        public int Mileage { get; set; }
        public DateTime Insurance { get; set; }
        public int NextTechServ
        {
            get { return ((((Mileage / 10000) * 10000) + 10000) - Mileage); }
            set { }
        }

        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
