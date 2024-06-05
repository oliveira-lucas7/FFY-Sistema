using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FindForYou.Models
{
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código da Observação")]
        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Observação")]
        public string ObservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local")]
        public string ObservacoesLocal { get; set; } = string.Empty;

        [Column("ObservacoesData")]
        [Display(Name = "Data")]
        public DateTime ObservacoesData { get; set; }

        [ForeignKey("ObjetoId")]
        public int ObjetoId { get; set; }
        public Objeto? Objeto { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
