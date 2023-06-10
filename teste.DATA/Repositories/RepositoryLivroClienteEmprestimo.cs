using teste.DATA.Interfaces;
using teste.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.DATA.Repositories
{
    public class RepositoryLivroClienteEmprestimo : RepositoryBase<LivroCliente>, IRepositoryLivroClienteEmprestimo
    {
        public RepositoryLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {
        }
    }
}
