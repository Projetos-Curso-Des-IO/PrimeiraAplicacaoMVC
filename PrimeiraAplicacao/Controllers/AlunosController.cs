using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraAplicacao.Data;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Controllers
{
    public class AlunosController : Controller
    {

		private readonly AppDbContext _context;

		public AlunosController(AppDbContext context)
		{
			_context = context;
		}

		//Get Listar
		public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.ToListAsync());
        }

		//Get Criar
		public IActionResult Create()
		{
			return View();
		}



		//Criar - Editar
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult>Create([Bind("Id,Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao,Ativo")] Aluno aluno)
		{

			if (ModelState.IsValid)
			{
				_context.Alunos.Add(aluno);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(aluno);
			
		}

		//Get Detelhe{id}
		public async Task<IActionResult> Details(int id)
		{
			var aluno = await _context.Alunos.FirstOrDefaultAsync(m => m.Id == id);
			if (id == null)
			{
				return NotFound();
			}
			return View(aluno);
		}


		//Get Editar{id}
		public async Task<IActionResult> Edit(int id)
		{
			var aluno = await _context.Alunos.FindAsync(id);
			return View(aluno);
		}


		//Editar-Post
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNascimento,Email,,Avaliacao,Ativo")] Aluno aluno)
		{

			if (id != aluno.Id)
			{
				return NotFound();				
			}

			ModelState.Remove("EmailConfirmacao");

			if (ModelState.IsValid)
			{
				_context.Alunos.Update(aluno);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(aluno);			
		}
	}
}
