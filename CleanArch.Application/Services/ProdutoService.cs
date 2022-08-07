using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
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

        //public async Task<ProdutoDTO> GetProdutoId(int? id)
        //{
        //    var produtoEntity = await _produtoRepository.GetProdutoId(id);
        //    return _mapper.Map<ProdutoDTO>(produtoEntity);
        //}

        //public async Task Add(ProdutoDTO produtoDto)
        //{
        //    var produtoEntity = _mapper.Map<Produto>(produtoDto);
        //    await _produtoRepository.CreateProduto(produtoEntity);
        //}

        //public async Task Update(ProdutoDTO produtoDto)
        //{
        //    var produtoEntity = _mapper.Map<Produto>(produtoDto);
        //    await _produtoRepository.UpdateProduto(produtoEntity);
        //}

        //public async Task Remove(int? id)
        //{
        //    var produtoEntity = _produtoRepository.GetProdutoId(id).Result;
        //    await _produtoRepository.RemoveProduto(produtoEntity);
        //}

    }
}
