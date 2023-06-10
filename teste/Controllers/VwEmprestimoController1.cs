using teste.DATA.Models;
using teste.DATA.Services;
using teste.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.DATA.Controllers
{
    public class VwEmprestimoController1 : Controller
    {
        public VwLivroClienteService _service = new VwLivroClienteService();

        public IActionResult Index()
        {

            List<VwEmprestimo> oListEmprestimo = _service.oRepositoryVwLivroClienteEmprestimo.SelecionarTodos();
            return View(oListEmprestimo);
        }
        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            List<Livro> oListLivro = _service.oRepositoryLivro.SelecionarTodos();
            List<Cliente> oListCLiente = _service.oRepositoryCliente.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = oListCLiente;
            oEmprestimoViewModel.oListLivro = oListLivro;

            oEmprestimoViewModel.oLivroClienteEmprestimo = new LivroCliente();

            oEmprestimoViewModel.oLivroClienteEmprestimo.DataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.oLivroClienteEmprestimo.DataDevolucao = DateTime.Now.AddDays(7);


            return View(oEmprestimoViewModel);
        }
        [HttpPost]
        public IActionResult Create(LivroCliente oLivroClienteEmprestimo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _service.oRepositoryLivroClienteEmprestimo.Incluir(oLivroClienteEmprestimo);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();

            oEmprestimoViewModel.oListCliente = _service.oRepositoryCliente.SelecionarTodos();
            oEmprestimoViewModel.oListLivro = _service.oRepositoryLivro.SelecionarTodos();

            LivroCliente oLivroClienteEmprestimo = _service.oRepositoryLivroClienteEmprestimo.SelecionarPK(id);
            oEmprestimoViewModel.oLivroClienteEmprestimo = oLivroClienteEmprestimo;


            return View(oEmprestimoViewModel);
        }
        [HttpPost]
        public IActionResult Edit(EmprestimoViewModel oEmprestimoViewModel)
        {
            if (!ModelState.IsValid)
            {
                oEmprestimoViewModel.oListCliente = _service.oRepositoryCliente.SelecionarTodos();
                oEmprestimoViewModel.oListLivro = _service.oRepositoryLivro.SelecionarTodos();
                return View(oEmprestimoViewModel);
            }


            _service.oRepositoryLivroClienteEmprestimo.Alterar(oEmprestimoViewModel.oLivroClienteEmprestimo);

            return RedirectToAction("Index");
        }

    }
}
