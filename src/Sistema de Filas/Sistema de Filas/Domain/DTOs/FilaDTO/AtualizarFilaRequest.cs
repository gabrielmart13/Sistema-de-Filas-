namespace Sistema_de_Filas.Domain.DTOs.FilaDTO
{
    public class AtualizarFilaRequest
    {
        public string Nome { get; set; } = String.Empty;
        public string? Descricao { get; set; }
        public bool Ativa { get; set; }

    }
}
