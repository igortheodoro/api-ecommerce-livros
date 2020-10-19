using System.Collections.Generic;
using Newtonsoft.Json;
using ApiLivros.Data;
using ApiLivros.Models;
using Microsoft.AspNetCore.Mvc;
using ApiLivros.Data.Repositories.Interfaces;
using ApiLivros.Services.Interfaces;

namespace ApiLivros.Controllers
{
    public class LivroController : ControllerBase
    {
        private readonly ILivrosServices service;
        public LivroController(ILivrosServices service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("/livros")]
        public IActionResult Get(int pg)
        {
            return Ok(service.ObterLivros(pg, 5));
        }

        [HttpGet]
        [Route("/livro")]   
        public IActionResult Get(string code)
        {
            return Ok(service.ObterLivroEspecifico(code));
        }
    }
}
