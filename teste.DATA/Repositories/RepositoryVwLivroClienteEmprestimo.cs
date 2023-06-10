using teste.DATA.Interfaces;
using teste.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.DATA.Repositories
{
    public class RepositoryVwLivroClienteEmprestimo : RepositoryBase<VwEmprestimo>, IRepositoryVwLivroCliente
    {
        public RepositoryVwLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
