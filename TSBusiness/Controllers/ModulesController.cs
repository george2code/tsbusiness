using System.Web.Mvc;

namespace TSBusiness.Controllers
{
    public class ModulesController : Controller
    {
        // GET: Modules
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TemplateEmail()
        {
            return View();
        }
    }
}