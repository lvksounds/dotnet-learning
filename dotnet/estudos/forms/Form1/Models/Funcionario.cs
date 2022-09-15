using System;
using System.ComponentModel.DataAnnotations;

namespace Form1.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [RegularExpression(@"^/[a-zA-Z\u00C0-\u00FF ]+/i")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Mátricula é obrigatória")]
        [StringLength(5, ErrorMessage = "Máximo de 5 carateres")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Digite o setor.")]
        [Display(Name = "Setor de Trabalho")]
        public string Setor { get; set; }

        [Required(ErrorMessage = "Digite o cargo.")]
        [StringLength(25)]
        public string Cargo { get; set; }
    }
}
