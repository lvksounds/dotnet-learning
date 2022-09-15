using Microsoft.AspNetCore.Mvc;

namespace Form1.Controllers
{
    public class CadastroController : Controller
    {
        
        public IActionResult Cadastrar()
        {
            return View();
        }

        
        [HttpGet]
        public IActionResult Visualizar()
        {
            return View();
        }
        
        
        [HttpGet]
        public IActionResult Gerenciar()
        {
            return View();
        }
    }
}
