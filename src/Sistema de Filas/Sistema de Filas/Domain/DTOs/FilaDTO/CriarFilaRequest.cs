namespace Sistema_de_Filas.Domain.DTOs.FilaDTO
{
    public class CriarFilaRequest
    {
        public string Nome { get; set; } = String.Empty;
        public string? Descricao { get; set; }
    }
}
