using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task<Usuario> AdicionarUsuario(Usuario usuario);
        public Task<Usuario> AtualizarUsuario(int id,Usuario usuario);
        public Task<Usuario> DeletarUsuario(int id);
        public Task<List<Usuario>> PegarTodosUsuarios();
        public Task<Usuario?> PegarUsuario(int id);
        public Task<Usuario?> LoginAsync(string email, string senha);
    }
}
