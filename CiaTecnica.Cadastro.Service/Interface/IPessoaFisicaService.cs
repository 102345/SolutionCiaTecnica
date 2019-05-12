using CiaTecnica.Cadastro.Model;
using System.Collections.Generic;

namespace CiaTecnica.Cadastro.Service.Interface
{
    public interface IPessoaFisicaService
    {
        List<PessoaFisica> ListarPessoas();
        PessoaFisica BuscarPessoa(int id);
        void Inserir(PessoaFisica pessoaFisica);
        void Atualizar(PessoaFisica pessoaFisica);
        void Excluir(int id);
    }
}
