using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Models.Produtos.Queries
{
   public class GetProdutoPorIdQuery : IRequest<Produto>
   {
        public int Id { get; set; }
        public GetProdutoPorIdQuery(int id)
        {
            Id = id;
        }
   }
}
