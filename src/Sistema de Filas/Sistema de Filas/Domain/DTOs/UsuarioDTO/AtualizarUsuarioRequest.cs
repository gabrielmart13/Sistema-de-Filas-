namespace Sistema_de_Filas.Domain.DTOs.UsuarioDTO
{
    public class AtualizarUsuarioRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
