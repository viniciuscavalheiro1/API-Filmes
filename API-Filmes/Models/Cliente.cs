using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Filmes.Models
{
    [Table(name: "Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200), Required]
        public string? Nome { get; set; }
        [MaxLength(11), Required]
        public string CPF { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
    }
}
