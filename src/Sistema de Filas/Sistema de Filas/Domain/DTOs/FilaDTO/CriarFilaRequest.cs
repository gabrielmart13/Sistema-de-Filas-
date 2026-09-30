namespace Sistema_de_Filas.Domain.DTOs.FilaDTO
{
    public class CriarFilaRequest
    {
        //Isso define exatamente quais informacoes o usuario precisa informar para criar uma fila
        public string Nome { get; set; } = String.Empty;
        public string? Descricao { get; set; }
    }
}
