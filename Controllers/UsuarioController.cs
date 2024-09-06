using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
