using EventPlus.Domains;
using EventPlus.Interfaces;
using EventPlus_.Context;

namespace EventPlus.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Event_Context _context;
        public UsuarioRepository(Event_Context context)
        {
            _context = context;
        }

        public Usuario BuscarPorEmail(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(email)!;
                return usuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find()!;
                return usuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                 _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
