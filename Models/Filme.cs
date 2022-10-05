using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo titulo e obrigatorio")]
        [StringLength(60,MinimumLength = 3, ErrorMessage = "O titulo precisa ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O campo DataLancamento e obrigatorio")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""\w-]*$", ErrorMessage = "Genero em formato invalido")]
        [StringLength(30, ErrorMessage = "Maximo de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1,1000 , ErrorMessage ="O valor deve ser de 1 a 1000")]
        [Required(ErrorMessage = "O campo valor é obrigatorio")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo avaliação é obrigatorio")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage ="Somente Números")] 
        public int Avaliacao { get; set; }

    }
}