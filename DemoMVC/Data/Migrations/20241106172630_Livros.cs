using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class Livros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_LivroId",
                table: "Aluno",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Livro_LivroId",
                table: "Aluno",
                column: "LivroId",
                principalTable: "Livro",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Livro_LivroId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_LivroId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Aluno");
        }
    }
}
