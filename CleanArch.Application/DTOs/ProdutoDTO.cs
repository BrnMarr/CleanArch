﻿using CleanArch.Domain.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "campo Nome é Obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "campo Descrição obrigatório")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "campo Valor obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "campo Ação obrigatório")]
        [Range(1, 9999)]
        [DisplayName("Ação")]
        public int Stock { get; set; }

        [MaxLength(250)]
        [DisplayName("Imagem Produto")]
        public string Imagem { get; set; }

        public Categoria Categoria { get; set; }

        [DisplayName("Categorias")]
        public int CategoriaId { get; set; }

    }
}
