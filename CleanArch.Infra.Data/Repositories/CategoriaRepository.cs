using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        ApplicationDbContext _categoriaContext;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _categoriaContext = context;
        }

        public async Task<Categoria> CreateCategoria(Categoria categoria)
        {
            _categoriaContext.Add(categoria);
            await _categoriaContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> UpdateCategoria(Categoria categoria)
        {
            _categoriaContext.Categorias.Update(categoria);
            await _categoriaContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> GetCategoriaId(int? id)
        {
            return await _categoriaContext.Categorias.FindAsync(id);
        }

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            return await _categoriaContext.Categorias.ToListAsync();
        }

        public async Task<Categoria> RemoveCategoria(Categoria categoria)
        {
            _categoriaContext.Categorias.Remove(categoria);
            await _categoriaContext.SaveChangesAsync();
            return categoria;
        }
    }
}
