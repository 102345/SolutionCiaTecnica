using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CiaTecnica.Cadastro.Service;


namespace CiaTecnica.Cadastro.Test
{
    [TestClass]
    public class TestePessoa
    {
        [TestMethod]
        public void ListarPessoaFisica()
        {
            var pessoas = new PessoaFisicaService().ListarPessoas();

            Assert.AreNotEqual(null, pessoas);

        }

        [TestMethod]
        public void ListarPessoaJuridica()
        {
            var pessoasJ = new PessoaJuridicaService().ListarPessoas();

            Assert.AreNotEqual(null, pessoasJ);

        }




    }
}
