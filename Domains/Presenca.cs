using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Web;

namespace EventPlus.Domains
{
    [Table("Presenca")]
    public class Presenca
    {
        [Key]
        public Guid PresencaId { get; set; }

        [Column(TypeName = "BIT")]
        public bool? Situacao { get; set; }

        public Guid UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }


        public Guid EventoId { get; set; }
        [ForeignKey("EventoId")]
        public Evento? Evento { get; set; }

    }
}
