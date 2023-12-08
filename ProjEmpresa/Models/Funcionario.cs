using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjEmpresa.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime InicioTrabalho { get; set; }

        public virtual ICollection<Cadastro> Cadastro{ get; set; }
    }
}