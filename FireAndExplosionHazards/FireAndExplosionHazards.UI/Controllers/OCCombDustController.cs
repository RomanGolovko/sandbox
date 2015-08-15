using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Concrete.OC;

namespace FireAndExplosionHazards.UI.Controllers
{
    public class OCCombDustController : Controller
    {
        // GET: OCCombDust
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(CombDust data)
        {
            data.Z = data.SetZ();

            if (data.ΔР() < 5.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'В'(пожароопасная), " +
                    "так как ∆P = {0:F4} < 5 кПа", data.ΔР());
            else if (data.ΔР() >= 5.0 && data.Tв <= 28.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'А'(взрывоопасная), " +
                    "так как ∆P = {0:F4} > 5 кПа и Tв = {1} <= 28 °С", data.ΔР(), data.Tв);
            else if (data.ΔР() >= 5.0 && data.Tв >= 28.0)
                ViewBag.message = string.Format("Категория помещения по данному веществу - 'Б'(взрывоопасная), " +
                    "так как ∆P = {0:F4} > 5 кПа и Tв = {1} >= 28 °С", data.ΔР(), data.Tв);

            return PartialView(data);
        }
    }
}