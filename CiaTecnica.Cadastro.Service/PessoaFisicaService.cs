using CiaTecnica.Cadastro.DAL.Repositories;
using CiaTecnica.Cadastro.Model;
using CiaTecnica.Cadastro.Service.Interface;
using System.Linq;
using System.Collections.Generic;




namespace CiaTecnica.Cadastro.Service
{
    public class PessoaFisicaService : IPessoaFisicaService
    {
        private readonly PessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaService()
        {
            _pessoaFisicaRepository = new PessoaFisicaRepository();
        }


        public void Atualizar(PessoaFisica pessoaFisica)
        {
            _pessoaFisicaRepository.Update(pessoaFisica);
        }

        public PessoaFisica BuscarPessoa(int id)
        {
            return _pessoaFisicaRepository.GetById(id);
        }

        public void Excluir(int id)
        {
            _pessoaFisicaRepository.Remove(_pessoaFisicaRepository.GetById(id));
        }

        public void Inserir(PessoaFisica pessoaFisica)
        {
            _pessoaFisicaRepository.Add(pessoaFisica);
        }

        public List<PessoaFisica> ListarPessoas()
        {
            return _pessoaFisicaRepository.GetAll().OrderBy(x => x.Nome).ToList();
        }
    }
}
