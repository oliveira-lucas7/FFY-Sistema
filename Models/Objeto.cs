using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FindForYou.Models
{
    public class Objeto
    {
        [Column("ObjetoId")]
        [Display(Name = "Código do Objeto")]
        public int ObjetoId { get; set; }

        [Column("ObjetoNome")]
        [Display(Name = "Nome do Objeto")]
        public string ObjetoNome { get; set; } = string.Empty;

        [Column("ObjetoCor")]
        [Display(Name = "Cor do Objeto")]
        public string ObjetoCor { get; set; } = string.Empty;

        [Column("ObjetoObservacao")]
        [Display(Name = "Observação do Objeto")]
        public string ObjetoObservacao { get; set; } = string.Empty;

        [Column("ObjetoLocalDesaparecimento")]
        [Display(Name = "Local que Perdeu")]
        public string ObjetoLocalDesaparecimento { get; set; } = string.Empty;

        [Column("ObjetoFoto")]
        [Display(Name = "Foto do Objeto")]
        public string? ObjetoFoto { get; set; } = string.Empty;

        [Column("ObjetoDtDesaparecimento")]
        [Display(Name = "Data do desaparecimento do objeto")]
        public DateTime ObjetoDtDesaparecimento { get; set; }

        [Column("ObjetoDtEncontro")]
        [Display(Name = "Data de encontro do objeto")]
        public DateTime? ObjetoDtEncontro { get; set; }

        [Column("ObjetoStatus")]
        [Display(Name = "Status do Objeto")]
        public byte ObjetoStatus { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
