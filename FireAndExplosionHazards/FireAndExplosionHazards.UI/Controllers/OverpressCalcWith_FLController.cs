using System.Collections.Generic;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.OverpressCalcWith;
using FireAndExplosionHazards.UI.Models;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class OverpressCalcWith_FLController : Controller
    {
        // GET: OverpressCalcWith_FL/Index
        public ActionResult Index()
        {
            List<ValueZ> valueZ = new List<ValueZ>()
            {
                new ValueZ {Value = 0.3, Name = "ЛВЖ и ГЖ, которые нагреты до температуры вспышки и выше" },
                new ValueZ {Value = 0.3,
                    Name = "ЛВЖ и ГЖ, которые нагреты ниже температуры вспышки, при условии возможности образования аэрозоля" },
                new ValueZ {Value = 0,
                    Name = "ЛВЖ и ГЖ, которые нагреты ниже температуры вспышки, при невозможности образования аэрозоля" }
            };

            ViewBag.valueZ = new SelectList(valueZ, "Value", "Name", 2);

            return View();
        }

        [HttpPost]
        public ActionResult Result(OverpressCalcWith_FL data, double valueZ)
        {
            data.Z = valueZ;

            if (data.ΔР() >= 5.0 && data.Tв <= 28.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'А'(взрывоопасная), " +
                    "так как ∆P = {0:F4} > 5 кПа и Tв = {1} <= 28 °С", data.ΔР(), data.Tв);
            else if(data.ΔР() >= 5.0 && data.Tв >= 28.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'Б'(взрывоопасная), " +
                    "так как ∆P = {0:F4} > 5 кПа и Tв = {1} >= 28 °С", data.ΔР(), data.Tв);
            else if (data.ΔР() < 5.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'В'(пожароопасная), " + 
                    "так как ∆P = {0:F4} < 5 кПа", data.ΔР());

            return PartialView(data);
        }
    }
}