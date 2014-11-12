using System.Web.Mvc;
using TSBusiness.DataLayer;
using TSBusiness.DataLayer.Contract;
using TSBusiness.DataLayer.Repository;

namespace TSBusiness.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IUnitOfWork uow = null;
        private UserRepository repo = null;

        public HomeController()
        {
            uow = new UnitOfWork();
            repo = new UserRepository(uow);
        }

        public ActionResult Index()
        {
            var list = repo.GetAll();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}