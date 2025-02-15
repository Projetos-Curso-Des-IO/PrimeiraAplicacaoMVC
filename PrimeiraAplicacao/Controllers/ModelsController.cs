using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicacao.Models;
using static System.Net.Mime.MediaTypeNames;

namespace PrimeiraAplicacao.Controllers
{
	public class ModelsController : Controller
	{
		public IActionResult Index()
		{
			var aluno = new Aluno();

			//Validar modelo "aluno" com base nas DataAnnotations
			if (TryValidateModel(aluno))
			{
				return View(aluno);
			}

			// Obtém todos os erros de validação do ModelState.
			// O ModelState é um dicionário que contém o estado de cada propriedade do modelo,
			// incluindo erros de validação.
			var errors = ModelState.Select(x => x.Value.Errors)
				.Where(y => y.Count > 0)
				.ToList();


			errors.ForEach(x => Console.WriteLine(x.First().ErrorMessage));

			return View();
		}
	}
}
