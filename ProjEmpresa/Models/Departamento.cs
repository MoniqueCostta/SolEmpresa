using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace ProjEmpresa.Models
{
    public class Departamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartamentoID { get; set; }
        public string NomeArea { get; set; }
        public virtual ICollection<Cadastro> Cadastro { get; set; }


    }
}