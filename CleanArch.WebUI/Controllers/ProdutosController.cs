﻿using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.WebUI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ICategoriaService _categoriaService;

        public ProdutosController(IProdutoService produtoService,ICategoriaService categoriaService)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var produtos = await _produtoService.GetProdutos();

            ViewData["Title"] = "Gestão de Produtos"; 
            
            return View(produtos);
        }

        [HttpPost()]
        public async Task<ActionResult> Create(ProdutoDTO produtoDTO)
        {
            if (ModelState.IsValid)
            {
                await _produtoService.Add(produtoDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(produtoDTO);
        }

        [HttpGet()]
        public async Task<ActionResult> Create()
        {
            ViewBag.CategoriaID = new SelectList(await _categoriaService.GetCategorias(),"Id", "Nome");

            return View();
        }

    }
}
