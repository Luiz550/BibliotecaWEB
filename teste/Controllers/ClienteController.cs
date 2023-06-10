using teste.DATA.Models;
using teste.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace teste.DATA.Controllers
{
    public class ClienteController : Controller
    {
        public ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oClienteService.oRepositoryCliente.Incluir(model);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.SelecionarPK(id);
            return View(oCliente);
        }
        public IActionResult Edit(int id)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.SelecionarPK(id);
            return View(oCliente);
        }
        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.Alterar(model);
            int id = oCliente.IdCliente;
            return RedirectToAction("Details", new { id });
        }
        public IActionResult Delete(int id)
        {
            oClienteService.oRepositoryCliente.Excluir(id);
            return RedirectToAction("index");
        }
    }
}
