using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
using System.Reflection.Metadata;
using DemoMVC.Data.Migrations;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DemoMVC.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<DemoMVC.Models.Livro> Livro { get; set; } = default!;
        public DbSet<Models.Livro> livros {  get; set; }
        public DbSet<Models.Aluno> alunos { get; set; }
    }
}
