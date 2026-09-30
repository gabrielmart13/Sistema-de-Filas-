using Sistema_de_Filas.Data;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Filas.Data.Repositories
{
    public class UsuarioRepo : IUsuarioRepo
    {
        private readonly DataContext _context;

        public UsuarioRepo(DataContext context)//Injeção de dependencia do meu contexto
        {
            _context = context;
        }

        public async Task<Usuario> AdicionarAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario); //Adiciona o usuario no meu contexto
            await _context.SaveChangesAsync(); //Salva o usuario no meu banco de dados

            return usuario; //Retorna o usuario
        }

        public async Task<Usuario> AtualizarAsync(Usuario usuario)
        {
            _context.Usuarios.Update(usuario); //Atualizando o usuario no meu contexto
            await _context.SaveChangesAsync(); //Salvando o usuario atualizado no meu banco de dados

            return usuario; //Retorna o usuario
        }

        public async Task<Usuario> DeletarAsync(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario); //Removendo o usuario do meu contexto
            await _context.SaveChangesAsync(); //Salvando a remoção do meu banco de dados

            return usuario;
        }

        public async Task<Usuario?> PegarPorIdAsync(int id)
        {
            //Buscando meu usuario por id, o asNoTracking faz com que nao permita traquear a informação
            var usuario = await _context.Usuarios.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            return usuario;        
        }

        public async Task<List<Usuario>> PegarTodasAsync()
        {
            //Buscando todos os meus usuarios, o asNoTracking faz com que nao permita traquear a informação
            var usuarios = await _context.Usuarios.AsNoTracking().ToListAsync();
            return usuarios;
        }
    }

}