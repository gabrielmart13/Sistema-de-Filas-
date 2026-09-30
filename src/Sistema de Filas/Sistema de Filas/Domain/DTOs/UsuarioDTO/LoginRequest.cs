namespace Sistema_de_Filas.Domain.DTOs.UsuarioDTO
{
    public class LoginRequest
    {
        //Isso define as informações que o usuario precisa informar para fazer login
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
