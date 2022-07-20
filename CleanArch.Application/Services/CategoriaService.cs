
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
   public  class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;
        
        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaDTO>> GetCategorias()
        {
            var categoriasEntity = await _categoriaRepository.GetCategorias();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriasEntity);
        }

        public async Task<CategoriaDTO> GetCategoriaId(int? id)
        {
            var categoriaEntity = await _categoriaRepository.GetCategoriaId(id);
            return _mapper.Map<CategoriaDTO>(categoriaEntity);
        }
            
        public async Task Add(CategoriaDTO categoriaDto)
        {
            var categoriaEntity = _mapper.Map<Categoria>(categoriaDto);
            await _categoriaRepository.CreateCategoria(categoriaEntity);
        }
        
        public async Task Update(CategoriaDTO categoriaDto)
        {
            var categoriaEntity = _mapper.Map<Categoria>(categoriaDto);
            await _categoriaRepository.UpdateCategoria(categoriaEntity);
        }

        public async Task Remove(int? id)
        {
            var categoriaEntity = _categoriaRepository.GetCategoriaId(id).Result;
            await _categoriaRepository.RemoveCategoria(categoriaEntity);
        }

     
    }
}
