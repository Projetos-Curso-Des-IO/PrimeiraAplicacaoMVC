using Microsoft.EntityFrameworkCore;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Data
{
	public class AppDbContext : DbContext
	{
		// Construtor que recebe as opções de configuração
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
		public DbSet<Aluno> Alunos { get; set; }
	}
}
