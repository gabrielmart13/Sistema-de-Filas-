using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Data.Repositories.Interfaces
{
    public interface ISenhaRepo
    {
        public Task<List<Senha>> PegarTodasAsync();
        public Task<Senha?> PegarPorIdAsync(int id);
        public Task<Senha> AdicionarAsync(Senha senha);
        public Task<Senha> AtualizarAsync(Senha senha);
        public Task<Senha> DeletarAsync(Senha senha);
        public Task<Senha?> PegarUltimaSenhaAsync();

    }
}
