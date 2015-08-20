using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Garage.BLL.Abstract;
using Garage.BLL.DTO;
using Garage.BLL.Infrastructure;
using Garage.WebUI.Models;

namespace Garage.WebUI.Controllers
{
    [Authorize]
    public class VehiclesController : Controller
    {
        IService<VehicleDTO> vehicleService;
        public VehiclesController(IService<VehicleDTO> vehServ)
        {
            vehicleService = vehServ;
        }

        // GET: Vehicles
        [AllowAnonymous]
        public ActionResult Index()
        {
            Mapper.CreateMap<VehicleDTO, VehicleViewModel>();
            var vehicles = Mapper.Map<IEnumerable<VehicleDTO>, List<VehicleViewModel>>(vehicleService.GetAll());

            return View(vehicles);
        }

        // POST: Vehicles/Search/5
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Search(string str)
        {
            Mapper.CreateMap<VehicleDTO, VehicleViewModel>();
            var searchedVehicles = Mapper.Map<IEnumerable<VehicleDTO>, List<VehicleViewModel>>(vehicleService.Search(str));

            return PartialView(searchedVehicles);
        }

        // GET: Vehicles/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            Mapper.CreateMap<VehicleDTO, VehicleViewModel>();
            var vehicle = Mapper.Map<VehicleDTO, VehicleViewModel>(vehicleService.GetCurrent(id));

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            return View("Edit", new VehicleViewModel());
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            Mapper.CreateMap<VehicleDTO, VehicleViewModel>();
            var vehicle = Mapper.Map<VehicleDTO, VehicleViewModel>(vehicleService.GetCurrent(id));

            //Mapper.CreateMap<DriverDTO, DriverViewModel>();
            //var allDrivers = Mapper.Map<IEnumerable<DriverDTO>, List<DriverViewModel>>(driverService.GetAll());
            //ViewBag.drivers = new SelectList(allDrivers, "Id", "Name", 1);

            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        [HttpPost]
        public ActionResult Edit(VehicleViewModel vehicleModel)
        {
            try
            {
                Mapper.CreateMap<VehicleViewModel, VehicleDTO>();
                var vehicle = Mapper.Map<VehicleViewModel, VehicleDTO>(vehicleModel);
                vehicleService.Save(vehicle);
                TempData["message"] = string.Format("{0} has been saved", vehicle.Brand);

                return RedirectToAction("Index");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                return View(vehicleModel);
            }
        }

        // POST: Vehicles/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {
                VehicleDTO deletedVehicle = vehicleService.Delete(id);
                if (deletedVehicle != null)
                    TempData["message"] = string.Format("{0} was deleted", deletedVehicle.Brand);

                return RedirectToAction("Index");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                return View();
            }
        }
    }
}
