using Microsoft.AspNetCore.Mvc;
using teste.DATA.Models;
using teste.DATA.Services;

namespace teste.Controllers
{
   
    public class LivroController : Controller
    {
        public LivroService oLivroService = new LivroService();
        public IActionResult Index()
        {
            List<Livro> oListLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListLivro);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oLivroService.oRepositoryLivro.Incluir(model);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            return View(oLivro);
        }
        public IActionResult Edit(int id)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPK(id);
            return View(oLivro);
        }
        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.Alterar(model);
            int id = oLivro.IdLivro;
            return RedirectToAction("Details", new { id });
        }
        public IActionResult Delete(int id)
        {
            oLivroService.oRepositoryLivro.Excluir(id);
            return RedirectToAction("index");
        }
    }
}
