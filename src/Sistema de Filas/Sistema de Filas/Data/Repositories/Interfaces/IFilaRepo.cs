using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Data.Repositories.Interfaces
{
    public interface IFilaRepo
    {
        public Task<List<Fila>> PegarTodasAsync();
        public Task<Fila?> PegarPorIdAsync(int id);
        public Task<Fila> AdicionarAsync(Fila fila);
        public Task<Fila> AtualizarAsync(Fila fila);
        public Task<Fila> DeletarAsync(Fila fila);

    }
}
