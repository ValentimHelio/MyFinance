using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using System.Security.Cryptography.X509Certificates;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Login(int? id)
        {
            if(id != null && id == 0)
            {
                HttpContext.Session.SetInt32("IDUsuarioLogado", 0);
                HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
            }

            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                HttpContext.Session.SetInt32("IDUsuarioLogado", usuario.Id);
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Dados de Login Inválido!";
                return RedirectToAction("Login");
            }
        }
    }
}
