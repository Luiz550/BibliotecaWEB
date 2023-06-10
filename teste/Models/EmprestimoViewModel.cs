using teste.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace teste.Models
{
    public class EmprestimoViewModel
    {
        public Livro oLivro { get; set; }
        public Cliente oCliente { get; set; }
        public LivroCliente oLivroClienteEmprestimo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public int IdCliente { get; set; }
        public int IdLivro { get; set; }


        public List<Cliente> oListCliente { get; set; }
        public List<Livro> oListLivro { get; set; }
    }
}
