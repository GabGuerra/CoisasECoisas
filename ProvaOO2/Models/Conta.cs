using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaOO2.Models
{
    [Table("Conta")]
    public class Conta
    {
        [Key]        
        public int contaId { get; set; }
        [Required(ErrorMessage = "Digite o login.")]
        public string login { get; set; }
        [Required(ErrorMessage = "Digite a senha.")]
        public string senha { get; set; }
        [Required(ErrorMessage = "Digite o nome.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Digite o cpf.")]
        public string cpf { get; set; }
        [Required(ErrorMessage = "Digite o email.")]
        public string email { get; set; }

    }
}