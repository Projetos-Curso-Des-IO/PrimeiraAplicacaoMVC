using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicacao.Data;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Controllers
{
	public class TesteEFController : Controller
	{
		public AppDbContext Db { get; set; }

		public TesteEFController(AppDbContext db)
		{
			Db = db;
		}

		[Route("criarAluno")]
		public IActionResult Index()
		{

			var aluno = new Aluno()
			{
				Nome = "Josiel",
				Email = "josi2@gmail.com",
				DataNascimento = new DateTime(2011, 02, 12),
				Avaliacao = 6,
				Ativo = true
			};

			//Db.Alunos.Add(aluno);
			//Db.SaveChanges();

			var alunoResultado = Db.Alunos.Where(a => a.Nome.Contains("Josiel")).FirstOrDefault();
			alunoResultado.Nome = "Josiel costa martins";
			alunoResultado.Avaliacao = 9;

			Db.Alunos.Remove(alunoResultado);
			//Db.Alunos.Update(alunoResultado);
			Db.SaveChanges();
		

			return Content("");
		}
	}
}
