using Sistema_de_Filas.Data.Repositories.Interfaces;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Services.Interfaces;


namespace Sistema_de_Filas.Services
{
    public class FilaService : IFilaService
    {
        private readonly IFilaRepo _Filarepo;
        public FilaService (IFilaRepo Filarepo)
        {
            _Filarepo = Filarepo;
        }

        public async Task<Fila>AdicionarFila(Fila fila)
        {  
            if(string.IsNullOrWhiteSpace(fila.Nome))
            {
                throw new Exception("Não pode adicionar fila sem nome");
            }

            return await _Filarepo.AdicionarAsync(fila);
            
        }

        public Task<Fila> AtivarFila(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fila> AtualizarFila(int id, Fila fila)
        {
            var filaAtt = await _Filarepo.PegarPorIdAsync(id);

            if (filaAtt != null)
            {
                filaAtt.Nome = fila.Nome;
                filaAtt.Descricao = fila.Descricao;
                filaAtt.Ativa = fila.Ativa;

            }
            else
            {
                throw new Exception("Essa fila não existe");
            }
            if (string.IsNullOrWhiteSpace(filaAtt.Nome))
            {
                throw new Exception("Voce não pode deixar a fila sem nome");
            }

            return await _Filarepo.AtualizarAsync(filaAtt);

        }

        public async Task<Fila> DeletarFila(int id)
        {
            var filaDel = await _Filarepo.PegarPorIdAsync(id);

            if(filaDel == null)
            {
                throw new Exception("Voce nao pode excluir uma lista nao existente");
            }

            if (filaDel.Ativa)
            {
                throw new Exception("Voce não pode Deletar uma fila ativa");
            }

            return await _Filarepo.DeletarAsync(filaDel);


        }

        public Task<Fila> DesativarFila(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fila?> PegarFila(int id)
        {
            var filaGet = await _Filarepo.PegarPorIdAsync(id);
            if(filaGet == null)
            {
                throw new Exception("Essa lista não existe");
            }

            return filaGet;

        }

        public async Task<List<Fila>> PegarTodasFilas()
        {
            var filasGet = await _Filarepo.PegarTodasAsync();

            return filasGet;
        }
    }
}
