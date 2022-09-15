using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MinhaDemoMVC.Models;


namespace MinhaDemoMVC.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                // executa codigo
            }
            return View(filme);
        }
    }


}
