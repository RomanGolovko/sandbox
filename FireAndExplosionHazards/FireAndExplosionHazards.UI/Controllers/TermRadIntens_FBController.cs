using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.TermRadIntens;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class TermRadIntens_FBController : Controller
    {
        // GET: TermRadIntens_FB/Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(TermRadIntens_FB data)
        {
            return PartialView(data);
        }
    }
}