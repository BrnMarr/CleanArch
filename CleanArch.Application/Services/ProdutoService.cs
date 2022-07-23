using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoReporitory;
        private readonly IMapper _mapper;
        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoReporitory = produtoRepository ?? throw new ArgumentNullException(nameof(produtoRepository));
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoDTO>> GetProdutos()
        {
            var produtoEntity = await _produtoReporitory.GetProdutos();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtoEntity);
        }

        public async Task<ProdutoDTO> GetProdutoId(int? id)
        {
            var produtoEntity = await _produtoReporitory.GetProdutoId(id);
            return _mapper.Map<ProdutoDTO>(produtoEntity);
        }

        public async Task Add(ProdutoDTO produtoDto)
        {
            var produtoEntity = _mapper.Map<Produto>(produtoDto);
            await _produtoReporitory.CreateProduto(produtoEntity);
        }

        public async Task Update(ProdutoDTO produtoDto)
        {
            var produtoEntity = _mapper.Map<Produto>(produtoDto);
            await _produtoReporitory.UpdateProduto(produtoEntity);
        }

        public async Task Remove(int? id)
        {
            var produtoEntity = _produtoReporitory.GetProdutoId(id).Result;
            await _produtoReporitory.RemoveProduto(produtoEntity);
        }

    }
}
