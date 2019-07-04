using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaOO.Models
{
    [Table("Estoque")]
    public class Estoque
    {
        [Key]
        public int estoqueId { get; set; }        
        public int quantidade { get; set; }


        public int produtoId { get; set; }
        public virtual Produto produto { get; set; }
    }
}