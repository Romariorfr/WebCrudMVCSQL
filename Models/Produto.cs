﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCrudMVCSQL.Models
{
    [Table("produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
    }
}
