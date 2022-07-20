using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArch.Domain.Tests
{
    public class CategoriaUnitTest1
    {
        [Fact(DisplayName ="Criar Categoria com estado válido")]
        public void AddCategoria_ComParemetrosValidos_ResultObjectValidState()
        {
            Action action = () => new Categoria(1, "Categoria Nome");
            action.Should()
                  .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criar Categoria com Id Negativo")]
        public void AddCategoria_ValorDeIdNegativo()
        {
            Action action = () => new Categoria(-1, "Categoria Nome");
            action.Should()
                  .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                  .WithMessage("Id com valor inválido.");
        }
    }
}
