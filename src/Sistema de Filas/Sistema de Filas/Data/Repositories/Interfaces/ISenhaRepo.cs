using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Data.Repositories.Interfaces
{
    public interface ISenhaRepo
    {
        //Criando a interface de Senha, isso e basicamente a assinatura desses metodos que estao no SenhaRepo
        public Task<List<Senha>> PegarTodasAsync();
        public Task<Senha?> PegarPorIdAsync(int id);
        public Task<Senha> AdicionarAsync(Senha senha);
        public Task<Senha> AtualizarAsync(Senha senha);
        public Task<Senha> DeletarAsync(Senha senha);
        public Task<Senha?> PegarUltimaSenhaAsync();

    }
}
