using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Task<Categoria> AddCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> AtualizaCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetCategoriaId(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> RemoveCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
