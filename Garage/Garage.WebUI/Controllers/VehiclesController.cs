using System.Linq;
using System.Web.Mvc;

using Garage.Domain.Abstract;
using Garage.Domain.Entities;

namespace Garage.WebUI.Controllers
{
    public class VehiclesController : Controller
    {
        private IRepository<Vehicle> db;

        public VehiclesController(IRepository<Vehicle> vehiclesRepository)
        {
            db = vehiclesRepository;
        }

        public ActionResult Index()
        {
            return View(db.GetAll);
        }

        public ViewResult Edit(int? id)
        {
            Vehicle vehicle = db.GetAll.FirstOrDefault(d => d.Id == id);
            return View(vehicle);
        }

        [HttpPost]
        public ActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Save(vehicle);
                TempData["message"] = string.Format("{0} has been saved", vehicle.Brand);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(vehicle);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Vehicle());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Vehicle deletedVehicle = db.Delete(id);
            if (deletedVehicle != null)
                TempData["message"] = string.Format("{0} was deleted", deletedVehicle.Brand);

            return RedirectToAction("Index");
        }
    }
}