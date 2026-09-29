using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Filas.Domain.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;

    }
}
