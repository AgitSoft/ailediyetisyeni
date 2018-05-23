using System.Web.Mvc;

namespace AileDiyetisyeni.Controllers
{
    public class DietPackageController : Controller
    {
        // GET: DietPackage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dietpackages()
        {
            ViewBag.Message = "Dietpackages";

            return View();
        }
    }
}