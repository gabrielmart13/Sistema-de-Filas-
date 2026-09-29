namespace Sistema_de_Filas.Domain.DTOs.UsuarioDTO
{
    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
