using System.Collections.Generic;

using Garage.Domain.Entities;

namespace Garage.WebUI.Models
{
    class VehicleListViewModel
    {
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
