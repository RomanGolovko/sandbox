using System.Linq;
using System.Web.Mvc;

using Garage.Domain.Abstract;
using Garage.Domain.Entities;

namespace Garage.WebUI.Controllers
{
    public class DriversController : Controller
    {
        private IRepository<Driver> db;

        public DriversController(IRepository<Driver> driverRepository)
        {
            db = driverRepository;
        }

        public ActionResult Index()
        {
            return View(db.GetAll);
        }

        public ViewResult Edit(int? id)
        {
            Driver driver = db.GetAll.FirstOrDefault(d => d.Id == id);
            return View(driver);
        }

        [HttpPost]
        public ActionResult Edit(Driver driver)
        {
            if (ModelState.IsValid)
            {
                db.Save(driver);
                TempData["message"] = string.Format("{0} has been saved", driver.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(driver);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Driver());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Driver deletedDriver = db.Delete(id);
            if (deletedDriver != null)
                TempData["message"] = string.Format("{0} was deleted", deletedDriver.Name);

            return RedirectToAction("Index");
        }
    }
}