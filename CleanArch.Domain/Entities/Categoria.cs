using CleanArch.Domain.Validation;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    public sealed class Categoria : EntityBase
    {
        public string Nome { get;  private  set; }

        public Categoria(string nome)
        {
            ValidateDomain(nome);    
        }

        public Categoria(int id,string nome)
        {
            DomainExceptionValidation.When(id < 0, "Id com valor inválido.");
            Id = id;
            ValidateDomain(nome);
        }

        public void Update(string nome)
        {
            ValidateDomain(nome);
        }

        public ICollection<Produto> Produtos { get; set; }

        private void ValidateDomain(string nome)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome Invalido nome.Name");

            DomainExceptionValidation.When(nome.Length < 3, "Nome Invalido nome.Name");

            Nome = nome;    

        }


    }
}
