using Microsoft.EntityFrameworkCore;
using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Data
{
    public class DataContext : DbContext
    {
        //Criando o contexto da minha aplicacão
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        //Referenciando as minhas tabelas 
        public DbSet<Usuario> Usuarios { get; set; } 
        public DbSet<Fila> Filas { get; set; }
        public DbSet<Senha> Senhas { get; set; }
    }
}