using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.FireLoad;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class FireLoadController : Controller
    {
        // GET: FireLoad
        public ActionResult Index()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Result(FireLoad data)
        {
            return PartialView(data);
        }
    }
}