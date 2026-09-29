using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Services.Interfaces
{
    public interface ISenhaService
    {
        public Task<Senha> AdicionarSenha(Senha senha);
        public Task<Senha> AtualizarSenha(int id,Senha senha);
        public Task<Senha> DeletarSenha(int id);
        public Task<List<Senha>> PegarTodasSenhas();
        public Task<Senha?> PegarSenha(int id);
        public Task<Senha> ChamarProxima(int filaid);
        public Task<Senha> IniciarAtendimento(int id);
        public Task<Senha> FinalizarAtendimento(int id);
    }
}
