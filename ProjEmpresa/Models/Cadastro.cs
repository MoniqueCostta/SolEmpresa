using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjEmpresa.Models
{
    public enum Grade
    {
        Manhã, Tarde, Noite, F
    }

    public class Cadastro
    {
        public int CadastroID { get; set; }
        public int DepartamentoID { get; set; }
        public int FuncionarioID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual Funcionario Funcionario{ get; set; }


    }
}