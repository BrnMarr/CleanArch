using CleanArch.Application.Models.Produtos.Commands;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Application.Models.Produtos.Handlers
{
    public class ProdutoUpdateCommandHandler : IRequestHandler<ProdutoUpdateCommand, Produto>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoUpdateCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ?? throw new ArgumentException(nameof(produtoRepository));
        }
        public async Task<Produto> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.GetProdutoId(request.Id);

            if (produto == null)
            {
                throw new ApplicationException("Erro ao atualizar o produto.");
            }
            else
            {
                produto.UpdateProduto(request.Nome, request.Descricao, request.Preco, request.Stock, request.Imagem, request.CategoriaId);

                return await _produtoRepository.UpdateProduto(produto);
            }

        }
    }
}
