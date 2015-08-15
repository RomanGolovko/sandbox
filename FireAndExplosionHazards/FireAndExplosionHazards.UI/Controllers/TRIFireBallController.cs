using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.TRI;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class TRIFireBallController : Controller
    {
        // GET: TRIFireBall
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(FireBall data)
        {
            return PartialView(data);
        }
    }
}