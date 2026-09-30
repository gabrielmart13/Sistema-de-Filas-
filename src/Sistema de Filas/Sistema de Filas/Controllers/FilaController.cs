using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Sistema_de_Filas.Data.Repositories;
using Sistema_de_Filas.Domain.DTOs.FilaDTO;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Services.Interfaces;

namespace Sistema_de_Filas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilaController : ControllerBase
    {
        private readonly IFilaService _filaservice;

        public FilaController(IFilaService filaservice)
        {
            _filaservice = filaservice;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _filaservice.PegarTodasFilas();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var usuario = await _filaservice.PegarFila(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CriarFilaRequest request)
        {
            var fila = new Fila
            {
                Nome = request.Nome,
                Descricao = request.Descricao
            };
            return Ok(await _filaservice.AdicionarFila(fila));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, AtualizarFilaRequest request)
        {
            var fila = new Fila
            {
                Nome = request.Nome,
                Descricao = request.Descricao,
                Ativa = request.Ativa
            };

            return Ok(await _filaservice.AtualizarFila(id, fila));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _filaservice.DeletarFila(id));
        }


    }
}
