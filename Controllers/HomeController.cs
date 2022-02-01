using System.Collections.Generic;
using destinoCerto.Models;
using Microsoft.AspNetCore.Mvc;

namespace destinoCerto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vitrine()
        {
            PacotesRepository pr = new PacotesRepository();
            List<PacotesTuristicos> pacotes = pr.Listar();
            return View(pacotes);
        }
    }
}
