using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
  public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria> GetCategoriaId(int? id);
        Task<Categoria> AddCategoria(Categoria categoria);
        Task<Categoria> AtualizaCategoria(Categoria categoria);
        Task<Categoria> RemoveCategoria(Categoria categoria);


    }
}
