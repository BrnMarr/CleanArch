using Microsoft.AspNetCore.Mvc;

namespace CleanArch.WebUI.Controllers.Perfil
{
    public class PerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
