using ProvaOO2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaOO.Models
{
    [Table("Conta")]
    public class Conta: Pessoa
    {
        [Key]        
        public int contaId { get; set; }
        [Required(ErrorMessage = "Digite o login.")]
        public string login { get; set; }
        [Required(ErrorMessage = "Digite a senha.")]
        public string senha { get; set; }
        

    }
}