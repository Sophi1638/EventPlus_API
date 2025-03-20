using EventPlus.Domains;
using EventPlus.Interfaces;
using EventPlus_.Context;
using EventPlus_.Domains;

namespace EventPlus.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly Event_Context _context;
        public ComentarioRepository(Event_Context context)
        {
            _context = context;
        }

        public Comentario BuscarPorId(Guid UsuarioID, Guid EventoID)
        {
            try
            {
                Comentario comentarioBuscado = _context.Comentario.Find()!;
                return comentarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Comentario comentario)
        {
            try
            {
                _context.Comentario.Add(comentario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Excluir(Comentario comentario)
        {
            try
            {
                Comentario Comentario = _context.Comentario.Find()!;
                if
                    (Comentario != null)
                {
                    _context.TipoUsuario.Remove(Comentario);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Comentario> Listar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

