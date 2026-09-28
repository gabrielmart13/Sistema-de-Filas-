using Sistema_de_Filas.Data;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Sistema_de_Filas.Data.Repositories
{
    public class FilaRepo : IFilaRepo
    {
        private readonly DataContext _context;
        public FilaRepo (DataContext context)
        {
            _context = context;
        }
        public async Task<Fila?> PegarPorIdAsync(int id)
        {
            var fila = await _context.Filas.AsNoTracking()
                  .FirstOrDefaultAsync(x => x.Id == id);
            
            return fila;
        }
        public async Task<List<Fila>> PegarTodasAsync()
        {
            var filas = await _context.Filas.AsNoTracking().ToListAsync();
            return filas;

        }
        public async Task<Fila> DeletarAsync(Fila fila)
        {
            _context.Filas.Remove(fila);
            await _context.SaveChangesAsync();

            return fila;
        }

        public async Task<Fila> AtualizarAsync(Fila fila)
        {
            _context.Filas.Update(fila);
            await _context.SaveChangesAsync();

            return fila;
        }

        public async Task<Fila> AdicionarAsync(Fila fila)
        {
            _context.Filas.Add(fila);
            await _context.SaveChangesAsync();

            return fila;

        }
    }
}
