using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Sistema_de_Filas.Data.Repositories;
using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SenhaController : ControllerBase
    {
        private readonly SenhaRepo _senharepo;

        public SenhaController(SenhaRepo senharepo)
        {
            _senharepo = senharepo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Senha senha)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Senha senha)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}
