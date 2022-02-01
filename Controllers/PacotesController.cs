using System.Collections.Generic;
using destinoCerto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace destinoCerto.Controllers
{
    public class PacotesController : Controller
    {
        public IActionResult CadastroPacote()
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpPost]
        public IActionResult CadastroPacote(PacotesTuristicos p)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            PacotesRepository pr = new PacotesRepository();
            int userId = (int)HttpContext.Session.GetInt32("idUsuario");
            pr.Insert(p, userId);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View();
        }
        public IActionResult ListaPacote()
        {
            PacotesRepository pr = new PacotesRepository();
            List<PacotesTuristicos> pacotes = pr.Listar();
            return View(pacotes);
        }

        public IActionResult EditarPacote(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            PacotesRepository pr = new PacotesRepository();
            PacotesTuristicos pct = pr.BuscarPorId(id);
            return View(pct);
        }
        [HttpPost]
        public IActionResult EditarPacote(PacotesTuristicos pct)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            PacotesRepository pr = new PacotesRepository();
            pr.Atualizar(pct);
            ViewBag.Mensagem = "Registro atualizado com sucesso!";
            return RedirectToAction("ListaPacote");
        }

        public IActionResult RemoverPacote(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            PacotesRepository pr = new PacotesRepository();
            pr.Remover(id);
            return RedirectToAction("ListaPacote");
        }
    }
}