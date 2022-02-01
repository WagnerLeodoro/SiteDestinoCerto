using System.Collections.Generic;
using destinoCerto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace destinoCerto.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(u);
            ViewBag.Mensagem = "Usuário cadastrado com sucesso!";
            return View();
        }

        public IActionResult Lista()
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            };
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> usuarios = ur.Listar();
            return View(usuarios);
        }

        public IActionResult Editar(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.BuscarPorId(id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Editar(Usuario u)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            UsuarioRepository ur = new UsuarioRepository();
            ur.Atualizar(u);
            return RedirectToAction("Lista");
        }

        public IActionResult Remover(int id)
        {
            if (HttpContext.Session.GetInt32("idUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            UsuarioRepository ur = new UsuarioRepository();
            ur.Remover(id);
            ViewBag.Mensagem = "Usuário atualizado com sucesso!";
            return RedirectToAction("Lista");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.QueryLogin(u);
            if (usuario != null)
            {
                ViewBag.Mensagem = "Você está logado!";
                HttpContext.Session.SetInt32("idUsuario", usuario.Id);
                HttpContext.Session.SetString("nomeUsuario", usuario.Nome);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mensagem = "Falha no login";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}