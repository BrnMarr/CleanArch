using CleanArch.Application.Models.Produtos.Commands;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;

using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Application.Models.Produtos.Handlers
{
    public class ProdutoCreateCommandHandler : IRequestHandler<ProdutoCreateCommand, Produto>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoCreateCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Produto> Handle(ProdutoCreateCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto(request.Nome, request.Descricao, request.Preco, request.Stock, request.Imagem);

            if (produto == null)
            {
                throw new ApplicationException("Erro ao criar o produto.");
            }
            else
            {
                produto.CategoriaId = request.CategoriaId;
                return await _produtoRepository.CreateProduto(produto);
            }

        }
    }
}
