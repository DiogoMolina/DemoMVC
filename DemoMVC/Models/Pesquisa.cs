using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace DemoMVC.Models
{
    public class Pesquisa
    {

        public string Nome { get; set; }

        public IList<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}
