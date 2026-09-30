using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Data.Repositories.Interfaces
{
    public interface IUsuarioRepo
    {
        //Criando a interface de Usuario, isso e basicamente a assinatura desses metodos que estao no UsuarioRepo
        public Task<List<Usuario>> PegarTodasAsync();
        public Task<Usuario?> PegarPorIdAsync(int id);
        public Task<Usuario> AdicionarAsync(Usuario usuario);
        public Task<Usuario> AtualizarAsync(Usuario usuario);
        public Task<Usuario> DeletarAsync(Usuario usuario);
    }
}
