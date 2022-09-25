using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArch.WebUI.Controllers
{
    [Authorize]
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
            var categorias = await _categoriaService.GetCategorias();
            ViewData["Title"] = "Gestão de Categorias";

            return View(categorias);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var categoryDTO = await _categoriaService.GetCategoriaId(id);

            if (categoryDTO == null)
                return NotFound();

            return View(categoryDTO);
         
        }


        [HttpPost]
        public async Task<ActionResult> Create(CategoriaDTO categoria)
        {
            if (ModelState.IsValid)
            {
                await _categoriaService.Add(categoria);
                return RedirectToAction(nameof(Index));
            }

            return View(categoria);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var categoriaDTO = await _categoriaService.GetCategoriaId(id);

            if (categoriaDTO == null) return NotFound();

            return View(categoriaDTO);

        }

        [HttpPost()]
        public async Task<IActionResult> Edit(CategoriaDTO categoriaDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _categoriaService.Update(categoriaDTO);
                }
                catch (System.Exception)
                {

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaDTO);          
        }

        [HttpGet()]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var categoriaDTO = await _categoriaService.GetCategoriaId(id);

            if (categoriaDTO == null) return NotFound();

            return View(categoriaDTO);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirma(int id)
        {
            await _categoriaService.Remove(id);
            return RedirectToAction("Index");
        }

    }
}
