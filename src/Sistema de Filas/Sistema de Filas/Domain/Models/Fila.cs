using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Filas.Domain.Models
{
    public class Fila
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string? Descricao { get; set; }
        public bool Ativa { get; set; } = true;
        public DateTime CriadaEm { get; set; }

    }
}
