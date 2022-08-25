using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Models.Produtos.Commands;
using CleanArch.Application.Models.Produtos.Queries;
using MediatR;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMediator _madiator;
        private readonly IMapper _mapper;
        
        public ProdutoService( IMapper mapper,IMediator mediator)
        {           
            _mapper = mapper;
            _madiator = mediator;
        }

        public async Task<IEnumerable<ProdutoDTO>> GetProdutos()
        {
            var produtosQuery = new GetProdutosQuery();

            if (produtosQuery == null)
                throw new Exception("Não foi possivel listar os produtos.");

            var result = await _madiator.Send(produtosQuery);

            return _mapper.Map<IEnumerable<ProdutoDTO>>(result);
        }

        public async Task<ProdutoDTO> GetProdutoId(int? id)
        {
            var produtoPorId = new GetProdutoPorIdQuery(id.Value);

            if (produtoPorId == null)
                throw new Exception("Não foi possivel consultar o produto.");
           
            var result = await _madiator.Send(produtoPorId);
            
            return _mapper.Map<ProdutoDTO>(result);
        }

        public async Task<ProdutoDTO> GetCategoriaPorId(int? id)
        {
            var produtoPorId = new GetProdutoPorIdQuery(id.Value);

            if (produtoPorId == null)
                throw new Exception("Não foi possivel consultar o produto.");

            var result = await _madiator.Send(produtoPorId);

            return _mapper.Map<ProdutoDTO>(result);
        }

        public async Task Add(ProdutoDTO produtoDto)
        {
            var produtoCreatCommand = _mapper.Map<ProdutoCreateCommand>(produtoDto);
            await _madiator.Send(produtoCreatCommand);
            
        }

        public async Task Update(ProdutoDTO produtoDto)
        {
            var produtoCreatCommand = _mapper.Map<ProdutoUpdateCommand>(produtoDto);
            await _madiator.Send(produtoCreatCommand);
        }

        public async Task Remove(int? id)
        {
            var produtoRemoveCommand = new ProdutoRemoveCommand(id.Value);

            if (produtoRemoveCommand == null)
                throw new Exception("Não foi possivel deletar o produto.");

            await _madiator.Send(produtoRemoveCommand);
        }
    }
}
