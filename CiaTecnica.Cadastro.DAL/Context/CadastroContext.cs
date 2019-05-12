using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CiaTecnica.Cadastro.Model;


namespace CiaTecnica.Cadastro.DAL.Context
{
    public class CadastroContext : DbContext
    {
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }

        public CadastroContext() : base("CadastroContext")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
