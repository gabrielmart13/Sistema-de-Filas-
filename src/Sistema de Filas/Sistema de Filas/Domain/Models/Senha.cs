using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_de_Filas.Domain.Models
{
    public class Senha
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Status { get; set; }
        public DateTime? CriadaEm { get; set; }
        public DateTime? ChamandoEm { get; set; }
        public DateTime? FinalizandoEm { get; set; }

        [ForeignKey(nameof(Usuario))]
        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey(nameof(Fila))]
        public int IdFila { get; set; }
        public Fila? Fila { get; set; }
    }
}
