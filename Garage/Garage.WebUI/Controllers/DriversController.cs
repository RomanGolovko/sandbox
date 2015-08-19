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
    public class DriversController : Controller
    {
        IService<DriverDTO> driverService;
        public DriversController(IService<DriverDTO> serv)
        {
            driverService = serv;
        }

        // GET: Drivers
        [AllowAnonymous]
        public ActionResult Index()
        {
            Mapper.CreateMap<DriverDTO, DriverViewModel>();
            var drivers = Mapper.Map<IEnumerable<DriverDTO>, List<DriverViewModel>>(driverService.GetAll());

            return View(drivers);
        }

        // GET: Drivers/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            Mapper.CreateMap<DriverDTO, DriverViewModel>();
            var driver = Mapper.Map<DriverDTO, DriverViewModel>(driverService.GetCurrent(id));

            return View(driver);
        }

        public ActionResult Create()
        {
            return View("Edit", new DriverViewModel());
        }

        // GET: Drivers/Edit/5
        public ActionResult Edit(int? id)
        {
            Mapper.CreateMap<DriverDTO, DriverViewModel>();
            var driver = Mapper.Map<DriverDTO, DriverViewModel>(driverService.GetCurrent(id));

            return View(driver);
        }

        // POST: Drivers/Edit/5
        [HttpPost]
        public ActionResult Edit(DriverViewModel driverModel)
        {
            try
            {
                Mapper.CreateMap<DriverViewModel, DriverDTO>();
                var driver = Mapper.Map<DriverViewModel, DriverDTO>(driverModel);
                driverService.Save(driver);
                TempData["message"] = string.Format("{0} has been saved", driver.Name);

                return RedirectToAction("Index");
            }
            catch(ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                return View(driverModel);
            }
        }

        // POST: Drivers/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {
                DriverDTO deletedDriver = driverService.Delete(id);

                if (deletedDriver != null)
                    TempData["message"] = string.Format("{0} was deleted", deletedDriver.Name);

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
