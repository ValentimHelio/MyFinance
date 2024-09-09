using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using System.Security.Cryptography.X509Certificates;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
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
