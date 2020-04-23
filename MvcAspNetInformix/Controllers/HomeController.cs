using System.Web.Mvc;

namespace MvcAspNetInformix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}