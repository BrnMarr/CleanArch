using CleanArch.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
  public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria> GetCategoriaId(int? id);
        Task<Categoria> CreateCategoria(Categoria categoria);
        Task<Categoria> UpdateCategoria(Categoria categoria);
        Task<Categoria> RemoveCategoria(Categoria categoria);


    }
}
