using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Domain.DTOs.SenhaDTO
{
    public class CriarSenhaRequest
    {
        //Isso define exatamente as informações que o usuario precisa informar para criar uma senha
        public int IdFila { get; set; }
        public int IdUsuario { get; set; }
    }
}
