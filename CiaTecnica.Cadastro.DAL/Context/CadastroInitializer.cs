using CiaTecnica.Cadastro.Model;
using System;
using System.Collections.Generic;

namespace CiaTecnica.Cadastro.DAL.Context
{
    public class CadastroInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CadastroContext>
    {
        protected override void Seed(CadastroContext context)
        {
            var pessoasFisicas = new List<PessoaFisica>
            {
                new PessoaFisica {CPF="111.111.111",
                    Bairro = "BairroA",
                    CEP ="1111-111",
                    Cidade ="CidadeA",
                    Complemento ="complementoA",
                    DataNascimento = Convert.ToDateTime("01/07/1977"),
                    Logradouro= "rua A",
                    Numero= "12",
                    UF= "SP",
                    Nome= "A",
                    Sobrenome= "AS"},


                new PessoaFisica {CPF="222.222.222",
                    Bairro = "Bairro B",
                    CEP ="2222-222",
                    Cidade ="CidadeB",
                    Complemento ="complementoB",
                    DataNascimento = Convert.ToDateTime("01/07/1999"),
                    Logradouro= "rua B",
                    Numero= "13",
                    UF= "CE",
                    Nome= "B",
                    Sobrenome= "BS"},


            };

            pessoasFisicas.ForEach(c => context.PessoasFisicas.Add(c));
            context.SaveChanges();




            var pessoasJuridicas = new List<PessoaJuridica>
            {
                new PessoaJuridica {CNPJ="111.111.111/1111-11",
                    Bairro = "BairroA",
                    CEP ="1111-111",
                    Cidade ="CidadeA",
                    Complemento ="complementoA",
                    Logradouro= "rua A",
                    Numero= "12",
                    UF= "SP",
                    NomeFantasia = "FantasiaA",
                    RazaoSocial= "Razao Social A"},


                 new PessoaJuridica {CNPJ="222.222.222/2222-22",
                    Bairro = "BairroB",
                    CEP ="2222-222",
                    Cidade ="CidadeB",
                    Complemento ="complementoB",
                    Logradouro= "rua B",
                    Numero= "12",
                    UF= "RJ",
                    NomeFantasia = "FantasiaB",
                    RazaoSocial= "Razao Social B"},



            };

            pessoasJuridicas.ForEach(c => context.PessoasJuridicas.Add(c));
            context.SaveChanges();

        }






    }
}
