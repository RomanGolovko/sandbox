using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.TermRadIntens;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class TermRadIntens_FLController : Controller
    {
        // GET: TermRadIntens_FL/Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(TermRadIntens_FL data)
        {
            return PartialView(data);
        }
    }
}