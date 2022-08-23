using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Models.Produtos.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {

        public DTOToCommandMappingProfile()
        {
            CreateMap<ProdutoDTO, ProdutoCreateCommand>();
            CreateMap<ProdutoDTO, ProdutoUpdateCommand>();
        }    
        
    }
}
