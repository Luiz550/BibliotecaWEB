using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.DATA.Repositories;

namespace teste.DATA.Services
{
    public class VwLivroClienteService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVwLivroClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }

        public RepositoryLivroClienteEmprestimo oRepositoryLivroClienteEmprestimo { get; set; }

        public VwLivroClienteService()
        {
            oRepositoryVwLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryCliente = new RepositoryCliente();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryLivroClienteEmprestimo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
