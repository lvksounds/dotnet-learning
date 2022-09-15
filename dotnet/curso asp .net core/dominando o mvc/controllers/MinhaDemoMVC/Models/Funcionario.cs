using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMVC.Models
{
    public class Funcionario
    {   
        [Required(ErrorMessage = "Matricula do funcionario requerida.")]
        [StringLength(5, ErrorMessage = "Tamanho Máximo da matricula: 5")]
        public string Matricula { get; set; }
    }
}
