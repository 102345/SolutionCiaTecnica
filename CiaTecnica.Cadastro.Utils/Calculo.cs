using System;

namespace CiaTecnica.Cadastro.Utils
{
    public  static class Calculo
    {
        public static int CalcularIdade(string dataNascimento)
        {
            int anoNascimento = Convert.ToInt32(dataNascimento.Substring(6, 4));
            int mesNascimento = Convert.ToInt32(dataNascimento.Substring(3, 2));
            int diaNascimento = Convert.ToInt32(dataNascimento.Substring(0, 2));

            var dtNascimentoT = new DateTime(anoNascimento, mesNascimento,diaNascimento);
            var hoje = DateTime.Today;

            var idade = hoje.Year - dtNascimentoT.Year;
            
            if (dtNascimentoT.Date > hoje.AddYears(-idade)) idade--;

            return idade;

        }
    }
}
