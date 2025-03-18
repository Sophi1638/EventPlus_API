using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EventPlus.Domains
{
    
        [Table("TipoEvento")]
        public class TipoEvento
        {
            [Key]
            public Guid TipoEventoID { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = " O tipo do evento eh obrigatorio")]

            public string? Tipo { get; set; }

        }
    }

