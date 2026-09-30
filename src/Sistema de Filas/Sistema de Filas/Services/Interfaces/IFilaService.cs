using Sistema_de_Filas.Domain.Models;

namespace Sistema_de_Filas.Services.Interfaces
{
    public interface IFilaService
    {
        //Isso define qual a assinatura dos metodos que são usados no Service
        public Task<Fila> AdicionarFila(Fila fila);
        public Task<Fila> AtualizarFila(int id, Fila fila);
        public Task<Fila> DeletarFila(int id);
        public Task<List<Fila>> PegarTodasFilas();
        public Task<Fila?> PegarFila(int id);
        public Task<Fila> AtivarFila(int id );
        public Task<Fila> DesativarFila(int id);
    }
}
