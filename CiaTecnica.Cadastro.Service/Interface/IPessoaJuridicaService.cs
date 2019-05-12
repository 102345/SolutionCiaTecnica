using CiaTecnica.Cadastro.Model;
using System.Collections.Generic;

namespace CiaTecnica.Cadastro.Service.Interface
{
    public interface IPessoaJuridicaService
    {
        List<PessoaJuridica> ListarPessoas();
        PessoaJuridica BuscarPessoa(int id);
        void Inserir(PessoaJuridica pessoaJuridica);
        void Atualizar(PessoaJuridica pessoaJuridica);
        void Excluir(int id);
    }
}
