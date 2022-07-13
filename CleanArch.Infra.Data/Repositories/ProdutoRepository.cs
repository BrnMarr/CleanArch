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
    public class ProdutoRepository : IProdutoRepository
    {
        ApplicationDbContext _produtoRepository;
        public ProdutoRepository(ApplicationDbContext context)
        {
            _produtoRepository = context;
        }

        public Task<Produto> AddProduto(Produto Produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> AtualizaProduto(Produto Produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetProdutoId(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetProdutos()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> RemoveProduto(Produto Produto)
        {
            throw new NotImplementedException();
        }
    }
}
