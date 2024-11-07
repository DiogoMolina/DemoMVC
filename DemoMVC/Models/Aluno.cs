using DemoMVC.Data.Migrations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        // Atributos

        [DisplayName("Nome:")]
        [StringLength(30,ErrorMessage = "O campo (nome) aceita no máximo 30 caracteres")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string? Name { get; set; }

        public string? Email { get; set; }

        [DataType(DataType.Date)]

        public DateTime DataCadastro { get; set; }
        public bool Ativo {  get; set; }

        [ForeignKey("Livro")]
        public int? LivroId { get; set; }
        public virtual Livro? Livro { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? Livros { get; set; }

    }
}
