using CiaTecnica.Cadastro.DAL.Repositories;
using CiaTecnica.Cadastro.Model;
using CiaTecnica.Cadastro.Service.Interface;
using System.Linq;
using System.Collections.Generic;

namespace CiaTecnica.Cadastro.Service
{
    public class PessoaJuridicaService : IPessoaJuridicaService
    {

        private readonly PessoaJuridicaRepository _pessoaJuridicaRepository;

        public PessoaJuridicaService()
        {
            _pessoaJuridicaRepository = new PessoaJuridicaRepository();
        }

        public void Atualizar(PessoaJuridica pessoaJuridica)
        {
            _pessoaJuridicaRepository.Update(pessoaJuridica);
        }

        public PessoaJuridica BuscarPessoa(int id)
        {
            return _pessoaJuridicaRepository.GetById(id);
        }

        public void Excluir(int id)
        {
            _pessoaJuridicaRepository.Remove(_pessoaJuridicaRepository.GetById(id));
        }

        public void Inserir(PessoaJuridica pessoaJuridica)
        {
            _pessoaJuridicaRepository.Add(pessoaJuridica);
        }

        public List<PessoaJuridica> ListarPessoas()
        {
            return _pessoaJuridicaRepository.GetAll().OrderBy(x => x.NomeFantasia).ToList();
        }
    }
}
