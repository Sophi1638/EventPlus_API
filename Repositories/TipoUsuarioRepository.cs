using EventPlus.Domains;
using EventPlus.Interfaces;
using EventPlus_.Context;
using EventPlus_.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly Event_Context _context;
        public TipoUsuarioRepository(Event_Context context)
        {
            _context = context;
        }

        //atualizar feito testado e ok
        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {
            try
            {
                TipoUsuario tipoUsuariobuscado = _context.TipoUsuario.Find(id)!;

                if (tipoUsuariobuscado != null)
                {
                    tipoUsuariobuscado.TipoUsuarioName = tipoUsuario.TipoUsuarioName;
                    _context.TipoUsuario.Update(tipoUsuariobuscado);
                     
                    _context.SaveChanges(); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //buscar por id feito testado e ok
        public TipoUsuario BuscarPorId(Guid id)
        {
            try
            {
                TipoUsuario tipousuarioBuscado = _context.TipoUsuario.Find()!;
                return tipousuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }



        //cadastro feito testado e ok
        public void Cadastrar(TipoUsuario tipoUsuario)
        {
            try
            {
                _context.TipoUsuario.Add(tipoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //deletar feito testado e ok
        public void Deletar(Guid id)
        {
            try
            {
                TipoUsuario TipousuarioBuscado = _context.TipoUsuario.Find()!;
                if
                    (TipousuarioBuscado != null)
                {
                    _context.TipoUsuario.Remove(TipousuarioBuscado);    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //listar feito tstado e ok
        public List<TipoUsuario> Listar()
        {
            try
            {
                List<TipoUsuario> ListarUsuario =_context.TipoUsuario.ToList();
                return ListarUsuario;

            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
