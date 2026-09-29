using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Domain.DTOs.SenhaDTO
{
    public class CriarSenhaRequest
    {
        public int IdFila { get; set; }
        public int IdUsuario { get; set; }
    }
}
