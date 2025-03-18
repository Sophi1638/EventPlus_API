
using EventPlus.Domains;
using EventPlus_.Domains;
using Microsoft.EntityFrameworkCore;
using static EventPlus.Domains.Evento;

namespace EventPlus_.Context
{

    public class Eventos_Context : DbContext
    {
        public Eventos_Context()
        {
        }

        public Eventos_Context(DbContextOptions<Eventos_Context> options) : base(options)
        {
        }

        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Instituicao> Instituicaos { get; set; }
        public DbSet<Presenca> Presencas { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-RLLR2QS\\SQLEXPRESS; Database = Event_Plus; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }

    }
}
