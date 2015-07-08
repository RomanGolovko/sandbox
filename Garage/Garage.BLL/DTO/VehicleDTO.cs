using System;

namespace Garage.BLL.DTO
{
    class VehicleDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string StateNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public DateTime Insurance { get; set; }

        public int DriverId { get; set; }
        public DriverDTO DriverDTO { get; set; }
    }
}
