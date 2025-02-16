using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.ViewComponents
{
	public class SaudacaoAlunoViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var aluno = new Aluno() { Nome = "Joao" };
			return View(aluno);
		}


	}
}
