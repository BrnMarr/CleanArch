using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArch.WebUI.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var categorias= await _categoriaService.GetCategorias();
            ViewData["Title"] = "Gestão de Categorias";

            return View(categorias);
        }
    }
}
