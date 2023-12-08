using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjEmpresa.Models;
using ContosoUniversity.DAL;

namespace ProjEmpresa.DAL
{
    public class EmpresaInicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpresaContexto>
    {
        protected override void Seed(EmpresaContexto context)
        {
            var funcionarios = new List<Funcionario>
            {
            new Funcionario{Nome="Carson",Sobrenome="Alexander",InicioTrabalho=DateTime.Parse("2005-09-01")},
            new Funcionario{Nome="Meredith",Sobrenome="Alonso",InicioTrabalho=DateTime.Parse("2002-09-01")},
            new Funcionario{Nome="Arturo",Sobrenome="Anand",InicioTrabalho=DateTime.Parse("2003-09-01")},
            new Funcionario{Nome="Gytis",Sobrenome="Barzdukas",InicioTrabalho=DateTime.Parse("2002-09-01")},
            new Funcionario{Nome="Yan",Sobrenome="Li",InicioTrabalho=DateTime.Parse("2002-09-01")},
            new Funcionario{Nome="Peggy",Sobrenome="Justice",InicioTrabalho=DateTime.Parse("2001-09-01")},
            new Funcionario{Nome="Laura",Sobrenome="Norman",InicioTrabalho=DateTime.Parse("2003-09-01")},
            new Funcionario{Nome="Nino",Sobrenome="Olivetto",InicioTrabalho=DateTime.Parse("2005-09-01")}
            };

            funcionarios.ForEach(s => context.Funcionarios.Add(s));
            context.SaveChanges();
            var courses = new List<Departamento>
            {
            new Departamento{DepartamentoID=1050,NomeArea="Chemistry",},
            new Departamento{DepartamentoID=4022,NomeArea="Microeconomics",},
            new Departamento{DepartamentoID=4041,NomeArea="Macroeconomics",},
            new Departamento{DepartamentoID=1045,NomeArea="Calculus",},
            new Departamento{DepartamentoID=3141,NomeArea="Trigonometry",},
            new Departamento{DepartamentoID=2021,NomeArea="Composition",},
            new Departamento{DepartamentoID=2042,NomeArea="Literature",}
            };
            courses.ForEach(s => context.Departamentos.Add(s));
            context.SaveChanges();
            var cadastros = new List<Cadastro>
            {
            new Cadastro{FuncionarioID=1,DepartamentoID=1050,Grade=Grade.Manhã},
            new Cadastro{FuncionarioID=1,DepartamentoID=4022,Grade=Grade.Noite},
            new Cadastro{FuncionarioID=1,DepartamentoID=4041,Grade=Grade.Tarde},
            new Cadastro{FuncionarioID=2,DepartamentoID=1045,Grade=Grade.Tarde},
            new Cadastro {FuncionarioID=2,DepartamentoID=3141,Grade=Grade.Noite},
            new Cadastro{FuncionarioID=2,DepartamentoID=2021,Grade=Grade.Manhã},
            new Cadastro{FuncionarioID=3,DepartamentoID=1050,Grade=Grade.Noite},
            new Cadastro{FuncionarioID=4,DepartamentoID=1050,Grade=Grade.Tarde},
            new Cadastro{FuncionarioID=4,DepartamentoID=4022,Grade=Grade.Manhã},
            new Cadastro{FuncionarioID=5,DepartamentoID=4041,Grade=Grade.Noite},
            new Cadastro{FuncionarioID=6,DepartamentoID=1045,Grade=Grade.Tarde},
            new Cadastro{FuncionarioID=7,DepartamentoID=3141,Grade=Grade.Manhã},
            };
            cadastros.ForEach(s => context.Cadastros.Add(s));
            context.SaveChanges();
        }
    }
}