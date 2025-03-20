using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventPlus_.Domains;

namespace EventPlus.Domains
{
  
        [Table("Eventos")]
        public class Evento
        {

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "Esse campo deve ser preenchido")]
            public string? Nome { get; set; }
          
            [Column(TypeName = "datetime")]
            [Required(ErrorMessage = "Esse campo deve ser preenchido")]
            public DateTime DataEvento { get; set; } 
            
            [Column(TypeName = "VARCHAR(50)")]
            public string? Descricao { get; set; }


            //---------------------------------------------------------------------------------
            //---------
            [Key]
            public Guid EventoId { get; set; }


            [ForeignKey("TipoEventoID")]
            public TipoEvento? Tipoevento { get; set; }
        
            [ForeignKey("InstituicaoID")]
            public Instituicao? Instituicao { get; set; }
            
           
            public Presenca? Presenca { get; set; }
        public object AcessoLivre { get; internal set; }
    }
    }

