using Sistema_de_Filas.Data.Repositories.Interfaces;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Services.Interfaces;

namespace Sistema_de_Filas.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepo _usuarioRepo;
        public UsuarioService (IUsuarioRepo UsuarioRepo)
        {
            _usuarioRepo = UsuarioRepo;
        }

        public async Task<Usuario> AdicionarUsuario(Usuario usuario)
        {
            if(string.IsNullOrWhiteSpace(usuario.Email) || 
                string.IsNullOrWhiteSpace(usuario.Tipo) || 
                string.IsNullOrWhiteSpace(usuario.Nome) ||
                string.IsNullOrWhiteSpace(usuario.SenhaHash))
            {
                throw new Exception("Voce precisa preencher todas informações para criar usuario");
            }
            return await _usuarioRepo.AdicionarAsync(usuario);

        }

        public async Task<Usuario> AtualizarUsuario(int id,Usuario usuario)
        {
            var usuarioAtt = await _usuarioRepo.PegarPorIdAsync(id);
            if(usuarioAtt != null)
            {
                usuarioAtt.Nome = usuario.Nome;
                usuarioAtt.Email = usuario.Email;
                usuarioAtt.SenhaHash = usuario.SenhaHash;
            }else
            {
                throw new Exception("Voce não pode atualizar esse usuario, ele não existe");
            }

            return await _usuarioRepo.AtualizarAsync(usuarioAtt);

        }

        public async Task<Usuario> DeletarUsuario(int id)
        {
            var usuarioDel = await _usuarioRepo.PegarPorIdAsync(id);
            
            if(usuarioDel == null)
            {
                throw new Exception("Esse usuario não existe, voce não pode exclui-lo");
            }

            return await _usuarioRepo.DeletarAsync(usuarioDel);
        }

        public async Task<Usuario?> PegarUsuario(int id)
        {
            var usuarioGet = await _usuarioRepo.PegarPorIdAsync(id);
            if(usuarioGet == null)
            {
                throw new Exception("Esse usuario não existe");
            }

            return usuarioGet;
        }

        public async Task<List<Usuario>> PegarTodosUsuarios()
        {
            var usuariosGet = await _usuarioRepo.PegarTodasAsync();

            return usuariosGet;
        }

        public Task<Usuario?> LoginAsync(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
