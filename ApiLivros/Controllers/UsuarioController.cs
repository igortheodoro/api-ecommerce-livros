using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLivros.Dto;
using ApiLivros.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiLivros.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuariosServices services;
        public UsuarioController(IUsuariosServices services)
        {
            this.services = services;
        }

        [HttpPost]
        [Route("/registrar")]
        public IActionResult Post([FromBody] CadastrarUsuarioDto usuario)
        {
            services.Registrar(usuario);
            return Ok();
        }
    }
}
