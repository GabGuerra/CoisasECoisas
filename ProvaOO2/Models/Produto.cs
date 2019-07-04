using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaOO.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int produtoId { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string descricao { get; set; }
        public bool openbox { get; set; }
    }
}