﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Garage.WebUI.Models
{
    public class DriverViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a driver name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a driver date of birth")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter a driver phone number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a driver medical certificate best before date")]
        public DateTime MedicalCertificate { get; set; }
    }
}