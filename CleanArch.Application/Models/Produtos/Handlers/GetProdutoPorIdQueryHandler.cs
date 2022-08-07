
using CleanArch.Application.Models.Produtos.Queries;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Application.Models.Produtos.Handlers
{
    public class GetProdutoPorIdQueryHandler : IRequestHandler<GetProdutoPorIdQuery, Produto>
    {
        private readonly IProdutoRepository _produtoRepository;
        public GetProdutoPorIdQueryHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Produto> Handle(GetProdutoPorIdQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetProdutoId(request.Id);
        }

    }
}
