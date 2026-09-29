using Sistema_de_Filas.Data.Repositories;
using Sistema_de_Filas.Data.Repositories.Interfaces;
using Sistema_de_Filas.Domain.Models;
using Sistema_de_Filas.Services.Interfaces;

namespace Sistema_de_Filas.Services
{
    public class SenhaService : ISenhaService
    {
        private readonly ISenhaRepo _senhaRepo;

        public SenhaService(ISenhaRepo senhaRepo)
        {
            _senhaRepo = senhaRepo;
        }

        public async Task<Senha> AdicionarSenha(Senha senha)
        {

            if (senha.IdFila <= 0 || senha.IdUsuario <= 0)
            {
                throw new Exception("Usuário ou fila inválidos");
            }

            var ultimaSenha = await _senhaRepo.PegarUltimaSenhaAsync();
            

            if (ultimaSenha == null)
            {
                senha.Numero = 1;
            }
            else
            {
                senha.Numero = ultimaSenha.Numero + 1;
            }

            senha.Status = "AGUARDANDO";
            senha.CriadaEm = DateTime.Now;
            

            return await _senhaRepo.AdicionarAsync(senha);
        }

        public async Task<Senha> AtualizarSenha(int id, Senha senha)
        {
            var senhaAtt = await _senhaRepo.PegarPorIdAsync(id);

            if(senhaAtt != null)
            {
                senhaAtt.Status = senha.Status;
                senhaAtt.ChamandoEm = senha.ChamandoEm;
                senhaAtt.Fila = senha.Fila;
                senhaAtt.Usuario = senha.Usuario;
            }
            else
            {
                throw new Exception("Essa senha não existe");
            }
            return await _senhaRepo.AtualizarAsync(senhaAtt);
        }

        public Task<Senha> ChamarProxima(int filaid)
        {
            throw new NotImplementedException();
        }

        public async Task<Senha> DeletarSenha(int id)
        {
            var senhaDel = await _senhaRepo.PegarPorIdAsync(id);
            if(senhaDel == null)
            {
                throw new Exception("Essa senha não existe, voce não pode exclui-la");
            }

            return await _senhaRepo.DeletarAsync(senhaDel);
        }

        public Task<Senha> FinalizarAtendimento(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Senha> IniciarAtendimento(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Senha?> PegarSenha(int id)
        {
            var senhaGet = await _senhaRepo.PegarPorIdAsync(id);
            if(senhaGet == null)
            {
                throw new Exception("Essa senha não existe");
            }

            return senhaGet;
        }

        public async Task<List<Senha>> PegarTodasSenhas()
        {
            var senhasGet = await _senhaRepo.PegarTodasAsync();

            return senhasGet;
        }
    }
}