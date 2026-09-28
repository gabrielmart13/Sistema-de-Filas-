using Sistema_de_Filas.Data;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Filas.Data.Repositories
{
    public class UsuarioRepo : IUsuarioRepo
    {
        private readonly DataContext _context;

        public UsuarioRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<Usuario> AdicionarAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<Usuario> AtualizarAsync(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<Usuario> DeletarAsync(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<Usuario?> PegarPorIdAsync(int id)
        {
            var usuario = await _context.Usuarios.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            return usuario;        
        }

        public async Task<List<Usuario>> PegarTodasAsync()
        {
            var usuarios = await _context.Usuarios.AsNoTracking().ToListAsync();
            return usuarios;
        }
    }

}