namespace Sistema_de_Filas.Domain.DTOs.FilaDTO
{
    public class AtualizarFilaRequest
    {
        //Isso define exatamente as informacoes que o usuario precisa informar para atualizar uma fila
        public string Nome { get; set; } = String.Empty;
        public string? Descricao { get; set; }
        public bool Ativa { get; set; }

    }
}
