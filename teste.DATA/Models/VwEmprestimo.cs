﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace teste.DATA.Models;



public partial class VwEmprestimo
{


    [Required]
    [Column("Nome")]
    [StringLength(50)]
    public string Nome { get; set; }
    [Required]
    [Column("Titulo")]
    [StringLength(50)]
    public string Titulo { get; set; }
    [Column("IdEmprestimo")]
    public int IdEmprestimo { get; set; }
    

    public int IdLivro { get; set; }


    public int IdCliente { get; set; }
    [Column(TypeName = "datetime")]

    public DateTime DataEmprestimo { get; set; }
    [Column(TypeName = "datetime")]

    public DateTime DataDevolucao { get; set; }

    public bool DataEntregue { get; set; }
}