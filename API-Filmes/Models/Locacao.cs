using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Filmes.Models
{
    [Table(name: "Locacao")]
    public class Locacao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Cliente")]
        public int Id_Cliente { get; set; }
        [ForeignKey("Filme")]
        public int Id_Filme { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataLocacao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDevolucao { get; set; }
    }
}
