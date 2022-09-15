using Microsoft.AspNetCore.Mvc;

namespace MinhaDemoMVC.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
