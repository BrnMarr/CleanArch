using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Models.Produtos.Commands
{
   public abstract class ProdutoCommand : IRequest<Produto>
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Stock { get; private set; }
        public string Imagem { get; private set; }
        public int CategoriaId { get; set; }
    }
}
