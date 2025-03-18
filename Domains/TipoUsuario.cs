using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{

    [Table("TipoUsuario")]

    public class TipoUsuario
    {
        [Key]
        public Guid Tipousuario { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        public string? TipoUsuarioName { get; set; }
    }
}

