using System.Collections.Generic;
using System.Web.Mvc;
using ExpressMapper;
using Garage.BLL.DTO;
using Garage.BLL.Interfaces;
using Garage.Web.Models;

namespace Garage.Web.Controllers
{
    public class DriversController : Controller
    {
        IDriverService driverService;
        public DriversController(IDriverService serv)
        {
            driverService = serv;
        }
        public ActionResult Index()
        {
            Mapper.Register<DriverDTO, DriverViewModel>();
            var drivers = Mapper.Map<IEnumerable<DriverDTO>, List<DriverViewModel>>(driverService.GetAllDrivers());
            return View(drivers);
        }
    }
}