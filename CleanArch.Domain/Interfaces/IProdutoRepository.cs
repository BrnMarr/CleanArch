using CleanArch.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
   public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetProdutoId(int? id);
        Task<Produto> CreateProduto(Produto produto);
        Task<Produto> UpdateProduto(Produto produto);
        Task<Produto> RemoveProduto(Produto produto);
    }
}
