using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Garage.WebUI.Models
{
    public class VehicleViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle brand")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle state number")]
        public string StateNum { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle color")]
        public string Color { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a vehicle release date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle VIN code")]
        public string VinCode { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle mileage")]
        public int Mileage { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a vehicle insurance best before date")]
        public DateTime Insurance { get; set; }

        public int? DriverId { get; set; }
    }
}