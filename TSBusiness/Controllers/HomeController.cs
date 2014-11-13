using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TSBusiness.DataLayer;
using TSBusiness.DataLayer.Contract;
using TSBusiness.DataLayer.Repository;
using TSBusiness.Utils;

namespace TSBusiness.Controllers
{
    [Authorize]
    public class HomeController : BaseController
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