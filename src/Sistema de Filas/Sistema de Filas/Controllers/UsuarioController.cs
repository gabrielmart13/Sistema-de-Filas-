using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Sistema_de_Filas.Data.Repositories;
using Sistema_de_Filas.Domain.DTOs.UsuarioDTO;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Services;
using Sistema_de_Filas.Services.Interfaces;

namespace Sistema_de_Filas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioservice;

        public UsuarioController(IUsuarioService usuarioservice)
        {
            _usuarioservice = usuarioservice;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _usuarioservice.PegarTodosUsuarios();

            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var usuario = await _usuarioservice.PegarUsuario(id);

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CriarUsuarioRequest request)
        {

            var usuario = new Usuario
            {
                Nome = request.Nome,
                Email = request.Email,
                SenhaHash = request.Senha,
                Tipo = request.Tipo
            };

            return Ok(await _usuarioservice.AdicionarUsuario(usuario));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, AtualizarUsuarioRequest request)
        {
            var usuario = new Usuario
            {
                Nome = request.Nome,
                Email = request.Email,
                SenhaHash = request.Senha
            };

            return Ok(await _usuarioservice.AtualizarUsuario(id,usuario));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _usuarioservice.DeletarUsuario(id));
        }


    }
}

