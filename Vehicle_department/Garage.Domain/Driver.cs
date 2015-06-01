using System;

namespace Garage.Domain
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Category { get; set; }
        public string PhoneNum { get; set; }
        public DateTime MedicalCertificate { get; set; }
    }
}
