using System.Collections.Generic;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.OverpressCalcWith;
using FireAndExplosionHazards.UI.Models;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class OverpressCalcWith_FGController : Controller
    {
        // GET: OverpressCalcWith_FG
        public ActionResult Index()
        {
            List<ValueZ> valueZ = new List<ValueZ>()
            {
                new ValueZ {Value = 1.0, Name = "Водород" },
                new ValueZ {Value = 0.5, Name = "ГГ (кроме водорода)" },
            };

            ViewBag.valueZ = new SelectList(valueZ, "Value", "Name", 2);

            return View();
        }

        [HttpPost]
        public ActionResult Result(OverpressCalcWith_FG data, double valueZ)
        {
            data.Z = valueZ;
            return PartialView(data);
        }
    }
}