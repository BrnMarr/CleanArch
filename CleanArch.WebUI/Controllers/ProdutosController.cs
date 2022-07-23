using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.WebUI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;   
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var produtos = await _produtoService.GetProdutos();

            ViewData["Title"] = "Gestão de Produtos"; 
            
            return View(produtos);
        }
    }
}
