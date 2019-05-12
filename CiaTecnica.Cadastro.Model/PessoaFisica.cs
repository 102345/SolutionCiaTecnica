using System;

namespace CiaTecnica.Cadastro.Model
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
