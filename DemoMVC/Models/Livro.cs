using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Area { get; set; }
        public int Ano { get; set; }
        public string? Editora { get; set; }

        [ForeignKey("Aluno")]
        public int? AlunoId { get; set; }
        public virtual Aluno? Aluno { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? Alunos { get; set; }
    }
}
