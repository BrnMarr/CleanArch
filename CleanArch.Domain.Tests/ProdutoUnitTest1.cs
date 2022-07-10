using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;


namespace CleanArch.Domain.Tests
{
    public class ProdutoUnitTest1
    {

        [Fact(DisplayName = "Criar Produto com estado válido")]
        public void AddProduto_ComParemetrosValidos_ResultObjectValidState()
        {
            Action action = () => new Produto(1, "Nome", "Desricao", 5000, 1, "IMG");
            action.Should()
                  .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criar Produto com Id Negativo")]
        public void AddProduto_ValorDeIdNegativo()
        {
            Action action = () => new Produto(-1, "Nome", "descrição", 5000, 1,"IMG");
            action.Should()
                  .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                  .WithMessage("Id com valor inválido.");
        }

    }
}
