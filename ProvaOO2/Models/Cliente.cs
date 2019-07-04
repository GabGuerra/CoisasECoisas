using ProvaOO2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaOO.Models
{
    [Table("Cliente")]
    public class Cliente : Pessoa
    {
        [Key]
        public int clienteId { get; set; }
    }
}