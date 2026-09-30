using Sistema_de_Filas.Data.Repositories.Interfaces;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Data;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Filas.Data.Repositories
{
    public class SenhaRepo : ISenhaRepo
    {
        private readonly DataContext _context;

        public SenhaRepo(DataContext context)//Injeção de dependencia do meu contexto
        {
            _context = context;
        }

        public async Task<List<Senha>> PegarTodasAsync()
        {
            var senhas = await _context.Senhas //Pegando todas as senhas, o asNoTracking faz com que a info não seja traqueada
                .AsNoTracking()
                .ToListAsync();

            return senhas;
        }

        public async Task<Senha?> PegarPorIdAsync(int id) 
        {
            var senha = await _context.Senhas //Pegando a senha por id
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return senha;
        }

        public async Task<Senha> AdicionarAsync(Senha senha)
        {
            _context.Senhas.Add(senha);
            await _context.SaveChangesAsync();

            return senha;
        }

        public async Task<Senha> AtualizarAsync(Senha senha)
        {
            _context.Senhas.Update(senha);
            await _context.SaveChangesAsync();

            return senha;
        }

        public async Task<Senha> DeletarAsync(Senha senha)
        {
            _context.Senhas.Remove(senha);
            await _context.SaveChangesAsync();

            return senha;
        }

        public async Task<Senha?> PegarUltimaSenhaAsync()
        {
            var ultimaSenha = await _context.Senhas.OrderByDescending(x => x.Numero).FirstOrDefaultAsync();

            return ultimaSenha;
        }
    }
}