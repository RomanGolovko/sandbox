using System;

namespace Garage.BLL.DTO
{
    public class DriverDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Category { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MedicalSertificate { get; set; }
    }
}
