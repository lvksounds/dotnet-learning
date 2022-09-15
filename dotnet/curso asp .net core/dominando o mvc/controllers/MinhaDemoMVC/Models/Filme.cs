using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60, MinimumLength = 2)]
        public string Titulo { get; set; }
        
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "Campo Data de Lançamento é obrigatório")]
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamento  { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0 - \u00FF""'\w-]*$")]
        [StringLength (60, MinimumLength = 2)]
        [Required(ErrorMessage = "Campo de Genero é obrigatório")]
        public string Genero { get; set; }

        [Range(1, 1000)]
        [Column(TypeName = "decimal(18,2")]
        [Required(ErrorMessage = "Preencha o campo valor.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo de Avaliação é obrigatório.")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números.")]
        public int Avaliacao  { get; set; }
    }
}
