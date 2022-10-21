using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaDTO>>> Get()
        {
            var categorias = await _categoriaService.GetCategorias();

            if (categorias == null)
                return NotFound("Categorias não existe");

            return Ok(categorias);
        }

        [HttpGet("{id:int}",Name ="GetCategoria")]
        public async Task<ActionResult<CategoriaDTO>> Get(int id)
        {
            var categoria = await _categoriaService.GetCategoriaId(id);

            if (categoria == null)
                return NotFound("Categoria não existe");

            return Ok(categoria);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoriaDTO categoria)
        {
            if (categoria == null)
                return BadRequest("Invalid Data");

            await _categoriaService.Add(categoria);

            return new CreatedAtRouteResult("GetCategoria", new { id = categoria.Id }, categoria );
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] CategoriaDTO categoria) 
        {
            if (id != categoria.Id)
                return BadRequest();

            if (categoria == null)
                return BadRequest();

          await _categoriaService.Update(categoria);

            return Ok(categoria);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CategoriaDTO>> Delete(int id)
        {
            var categoria = _categoriaService.GetCategoriaId(id);

            if (categoria.Result == null)
                return NotFound("Categoria não encontrada.");

            await _categoriaService.Remove(id);
            return Ok(categoria);

        }
    }
}
