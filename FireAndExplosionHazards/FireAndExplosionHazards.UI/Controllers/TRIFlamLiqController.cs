using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.TRI;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class TRIFlamLiqController : Controller
    {
        // GET: TRIFlamLiq
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(FlamLiq data)
        {
            return PartialView(data);
        }
    }
}