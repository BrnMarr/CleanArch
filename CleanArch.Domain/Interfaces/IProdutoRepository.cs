using CleanArch.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
   public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetProdutoId(int? id);
        Task<Produto> AddProduto(Produto Produto);
        Task<Produto> AtualizaProduto(Produto Produto);
        Task<Produto> RemoveProduto(Produto Produto);
    }
}
