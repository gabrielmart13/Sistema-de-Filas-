using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Sistema_de_Filas.Data.Repositories;
using Sistema_de_Filas.Domain.DTOs.SenhaDTO;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Services.Interfaces;

namespace Sistema_de_Filas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SenhaController : ControllerBase
    {
        private readonly ISenhaService _senhaservice;

        public SenhaController(ISenhaService senhaservice)
        {
            _senhaservice = senhaservice;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var senhas = await _senhaservice.PegarTodasSenhas();
            return Ok(senhas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var senha = await _senhaservice.PegarSenha(id);
            return Ok(senha);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CriarSenhaRequest request)
        {
            var senha = new Senha
            {
                IdFila = request.IdFila,
                IdUsuario = request.IdUsuario
            };
            return Ok(await _senhaservice.AdicionarSenha(senha));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Senha senha)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _senhaservice.DeletarSenha(id));
        }


    }
}
