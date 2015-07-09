using System.Collections.Generic;

using Garage.Domain.Entities;

namespace Garage.WebUI.Models
{
    public class DriverListViewModel
    {
        public IEnumerable<Driver> Drivers { get; set; }
    }
}
