using Microsoft.AspNetCore.Mvc;

namespace BerberShop.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
