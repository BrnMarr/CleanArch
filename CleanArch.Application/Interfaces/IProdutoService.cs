using CleanArch.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
   public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDTO>> GetProdutos();
        //Task<ProdutoDTO> GetProdutoId(int? id);
        //Task Add(ProdutoDTO produtoDto);
        //Task Update(ProdutoDTO produtoDto);
        //Task Remove(int? id);
    }
}
