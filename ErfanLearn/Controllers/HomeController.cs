using Microsoft.AspNetCore.Mvc;

namespace ErfanLearn.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
