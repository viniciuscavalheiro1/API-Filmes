using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Filmes.Models
{
    [Table(name: "Filme")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string? Titulo { get; set; }
        [Required]
        public int ClassificacaoIndicativa { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Lancamento { get; set; }

    }
}
