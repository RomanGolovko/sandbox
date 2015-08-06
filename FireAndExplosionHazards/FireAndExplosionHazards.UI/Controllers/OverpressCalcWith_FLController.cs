using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            return PartialView(data);
        }
    }
}