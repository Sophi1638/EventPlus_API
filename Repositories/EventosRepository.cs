using EventPlus.Domains;
using EventPlus.Interfaces;
using EventPlus_.Context;

namespace EventPlus.Repositories
{
    public class EventosRepository : IEventosRepository
    {
            private readonly Event_Context _context;
            public EventosRepository(Event_Context context)
            {
                _context = context;
            }

        public void Atualizar(Guid id, Evento evento)
        {
            try
            {
                Evento eventoBuscado = _context.Find(id);

                if (eventoBuscado != null)
                {
                    eventoBuscado.Nome = evento.Nome;
                    eventoBuscado.Descricao = evento.Descricao;
                    eventoBuscado.DataEvento = evento.DataEvento;
                    eventoBuscado.AcessoLivre = evento.AcessoLivre;
                    eventoBuscado.Instituicao = evento.Instituicao;
                    eventoBuscado.Tipoevento = evento.Tipoevento;
                    _context.Evento.Update(eventoBuscado);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Evento BuscarPorId(Guid id)
        {
            Evento eventoBuscado = _context.Evento.Find(id)!;
            return eventoBuscado;
        }

        public void Cadastrar(Evento evento)
        {
            try
            {
                _context.Evento.Add(evento);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                Evento evntoBuscado = _context.Evento.Find(id)!;

                _context.Evento.Find();
                if (evntoBuscado != null)
                {
                    _context.Evento.Remove(evntoBuscado);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Evento> Listar()
        {
            try
            {
                List<Evento> eventoBucado = _context.Evento.ToList();
                return eventoBucado;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Evento> ListarProximosEventos()
        {
            throw new NotImplementedException();
        }
    }
    }

