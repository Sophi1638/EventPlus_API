using EventPlus.Domains;
using EventPlus_.Context;
using EventPlus_.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly Event_Context _context;
        public TipoEventoRepository(Event_Context context)
        {
            _context = context;
        }

        //atualizar feito testado e ok
        public void Atualizar(Guid id, TipoEvento tipoEvento)
        {
            TipoEvento tipoEvetnoBuscado = _context.TipoEvento.Find()!;
            if (tipoEvetnoBuscado != null)
            {
                tipoEvetnoBuscado.Tipo = tipoEvento.Tipo;
                _context.TipoEvento.Update(tipoEvetnoBuscado);
                _context.SaveChanges();
            }
        }

        public TipoEvento BuscarPorId(Guid id)
        {
            try
            {
                TipoEvento tipoeventoBuscado = _context.TipoEvento.Find()!;
                return tipoeventoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Cadastrar feito testado e ok
        public void Cadastrar(TipoEvento novoTipoEvento)
        {
            try
            {
                _context.TipoEvento.Add(novoTipoEvento);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Deletar feito testado e ok
        public void Deletar(Guid id)
        {
            try
            {
                TipoEvento TipoEventoBuscado = _context.TipoEvento.Find()!;
                if (TipoEventoBuscado != null)
                {
                    _context.TipoEvento.Remove(TipoEventoBuscado);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoEvento> Listar()
        {
            List<TipoEvento> ListarUEvento = _context.TipoEvento.ToList();
            return ListarUEvento;
        }
    }
}
