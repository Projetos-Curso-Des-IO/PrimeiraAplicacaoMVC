using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiraAplicacao.Migrations
{
    /// <inheritdoc />
    public partial class v03_PrimeiraApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailConfirmacao",
                table: "Alunos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailConfirmacao",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
