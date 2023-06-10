using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste.DATA.Models
{
    public partial class SelecionarTodo
    {

        public string Nome { get; set; }
        public string Titulo { get; set; }
        public int IdEmprestimo { get; set; }
        public int IdCliente { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool DataEntregue { get; set; }
    }
}
