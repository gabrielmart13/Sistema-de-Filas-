using Sistema_de_Filas.Data.Repositories.Interfaces;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Services.Interfaces;


namespace Sistema_de_Filas.Services
{
    public class FilaService : IFilaService
    {
        private readonly IFilaRepo _Filarepo;
        public FilaService (IFilaRepo Filarepo) //Injeção de dependencia do filarepo, para poder usar os metodos dele
        {
            _Filarepo = Filarepo;
        }

        public async Task<Fila>AdicionarFila(Fila fila) //Adicionando uma fila
        {  
            if(string.IsNullOrWhiteSpace(fila.Nome))//Conferindo se a fila e nula ou tem espaço em branco
            {
                throw new Exception("Não pode adicionar fila sem nome"); //Retornando uma excessão caso necessario
            }

            return await _Filarepo.AdicionarAsync(fila); //Retornando a fila sendo adicionada com o metodo do filarepo
            
        }

        public Task<Fila> AtivarFila(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fila> AtualizarFila(int id, Fila fila)//Atualizando uma fila
        {
            var filaAtt = await _Filarepo.PegarPorIdAsync(id); //Pegando uma fila por id atravez do metodo do filarepo

            if (filaAtt != null)//Se a fila nao for nula vamos atualizar suas informações
            {
                filaAtt.Nome = fila.Nome;
                filaAtt.Descricao = fila.Descricao;
                filaAtt.Ativa = fila.Ativa;

            }
            else //Se ela for nula retorna a excessao
            {
                throw new Exception("Essa fila não existe");
            }
            if (string.IsNullOrWhiteSpace(filaAtt.Nome))
            {
                throw new Exception("Voce não pode deixar a fila sem nome");
            }

            return await _Filarepo.AtualizarAsync(filaAtt);//Retornando fila atualizada

        }

        public async Task<Fila> DeletarFila(int id)//Deletando uma fila
        {
            var filaDel = await _Filarepo.PegarPorIdAsync(id);

            if(filaDel == null)//Se a fila e nula retorna a excessao
            {
                throw new Exception("Voce nao pode excluir uma lista nao existente");
            }

            if (filaDel.Ativa)//Se a fila estiver ativa retorna a excessao 
            {
                throw new Exception("Voce não pode Deletar uma fila ativa");
            }

            return await _Filarepo.DeletarAsync(filaDel);//Retornando a fila delatada atraves do metodo do filarepo


        }

        public Task<Fila> DesativarFila(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fila?> PegarFila(int id)//Pegando uma fila por id
        {
            var filaGet = await _Filarepo.PegarPorIdAsync(id);
            if(filaGet == null)
            {
                throw new Exception("Essa lista não existe");
            }

            return filaGet; //Retornando a fila com o id escolhido

        }

        public async Task<List<Fila>> PegarTodasFilas()//Pegando todas as filas
        {
            var filasGet = await _Filarepo.PegarTodasAsync();//Metodo do filarepo para pegar todas as filas

            return filasGet;
            //Retornando todas as filas
        }
    }
}
