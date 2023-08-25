using Microsoft.AspNetCore.Mvc;

namespace AgLeather.Shop.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Header = "AgLeather Shop";
            ViewBag.Title = "Yönetici Paneli";
            return View();
        }
    }
}
