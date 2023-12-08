using ProjEmpresa.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class EmpresaContexto : DbContext
    {

        public EmpresaContexto() : base("EmpresaContexto")
        { }
        

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cadastro> Cadastros{ get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}