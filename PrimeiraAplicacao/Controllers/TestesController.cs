using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAplicacao.Controllers
{
	//[Route("/", Order = 0)]
	[Route("pedidos-vendas")]
	public class TestesController : Controller
	{


		public ActionResult Index()
		{
			return View();
		}

		[HttpGet("detalhes/{id:int}")]
		public ActionResult Details(int id, string teste, string teste2)
		{
			Console.WriteLine($"ID: {id} - teste: {teste} - teste2: {teste2}");
			return View();
		}





		[HttpGet("novo")]
		public ActionResult Create()
		{
			Console.WriteLine("Criar");
			return View();
		}

		[HttpPost("novo")]
		[ValidateAntiForgeryToken]
		public ActionResult Create([FromForm] IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}



		[HttpGet("editar")]
		public ActionResult Edit(int id)
		{
			return View();
		}

		[HttpPost("editar/{id:int}")]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, [FromForm] IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}




		[HttpGet("deletar{id:int}")]
		public ActionResult Delete(int id)
		{
			return View();
		}

		[HttpPost("deletar{id:int}")]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
