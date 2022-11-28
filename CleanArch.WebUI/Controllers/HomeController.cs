using CleanArch.Application.Interfaces;
using CleanArch.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IPerfilService _perfilService;
        private readonly IProdutoService _produtoService;
        public HomeController(IUsuarioService usuarioService, IPerfilService perfilService, IProdutoService produtoService)
        {   
            _usuarioService = usuarioService;
            _perfilService = perfilService;
            _produtoService = produtoService;

        }
    
        public IActionResult Index(LoginViewModel login)
        {
            var usuario = _usuarioService.GetUsuarioLogin(login.Email, login.Password);
                   
            if (usuario != null)
            {
                var painelUsuario = _perfilService.GetPerfil(usuario.idUsuario);
            }

            return View();
        }
    }
}
