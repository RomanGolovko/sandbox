using System.Collections.Generic;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.OverpressCalcWithOut;
using FireAndExplosionHazards.UI.Models;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class OverpressCalcWithOut_FGController : Controller
    {
        // GET: OverpressCalcWithOut_FG/Index
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
        public ActionResult Result(OverpressCalcWithOut_FG data, double valueZ)
        {
            data.Z = valueZ;

            if (data.ΔР() >= 5.0 && data.Tв <= 28.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'А'(взрывоопасная), " +
                    "так как ∆P = {0:F4} > 5 кПа и Tв = {1} <= 28 °С", data.ΔР(), data.Tв);
            else if (data.ΔР() >= 5.0 && data.Tв >= 28.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'Б'(взрывоопасная), " +
                    "так как ∆P = {0:F4} > 5 кПа и Tв = {1} >= 28 °С", data.ΔР(), data.Tв);
            else if (data.ΔР() < 5.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'В'(пожароопасная), " +
                    "так как ∆P = {0:F4} < 5 кПа", data.ΔР());

            return PartialView(data);
        }
    }
}