using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TutorialMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            ViewBag.Nome = "Lucas";
            
            return View();
        }

    }
}