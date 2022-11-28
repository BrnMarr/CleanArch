using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        ApplicationDbContext _produtoRepository;
        public ProdutoRepository(ApplicationDbContext context)
        {
            _produtoRepository = context;
        }

        public async Task<Produto> CreateProduto(Produto produto)
        {
            _produtoRepository.Add(produto);
            await _produtoRepository.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> UpdateProduto(Produto produto)
        {
            _produtoRepository.Produtos.Update(produto);
            await _produtoRepository.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> GetProdutoId(int? id)
        {
            return await _produtoRepository.Produtos.FindAsync(id);
          
        }

        public async Task<Produto> GetProdutoPorCategoria(int? id)
        {
            return await _produtoRepository.Produtos.Include(c => c.Categoria).SingleOrDefaultAsync(p => p.Id == id);

        }

        public async Task<IEnumerable<Produto>> GetProdutos()
        {
            return await _produtoRepository.Produtos.ToListAsync();
        }


        public async Task<Produto> RemoveProduto(Produto produto)
        {
            _produtoRepository.Produtos.Remove(produto);
            await _produtoRepository.SaveChangesAsync();
            return produto;
        }
    }
}
