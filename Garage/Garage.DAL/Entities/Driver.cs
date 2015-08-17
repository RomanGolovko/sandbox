using System;

namespace Garage.DAL.Entities
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Category { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MedicalCertificate { get; set; }
    }
}
