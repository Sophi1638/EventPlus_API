using EventPlus.Domains;
using EventPlus.Interfaces;
using EventPlus_.Context;

namespace EventPlus.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {
        private readonly Event_Context _context;
        public PresencaRepository(Event_Context context)
        {
            _context = context;
        }

        public void Atualizar(Presenca presenca)
        {
            Presenca presencaBuscado = _context.Presencas.Find()!;
            if (presencaBuscado != null)
            {
                presencaBuscado.PresencaId = presenca.PresencaId;
                _context.Presencas.Update(presencaBuscado);
                _context.SaveChanges();
            }
        }

        public void Deletar(Presenca presenca)
        {
            try
            {
                Presenca TipoPresenca = _context.Presencas.Find()!;
                if (presenca != null)
                {
                    _context.Presencas.Remove(presenca);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void inscrever(Presenca presenca)
        {
            try
            {
                _context.Presencas.Add(presenca);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Presenca> listar()
        {
            try
            {
                List<Presenca> ListarPresenca = _context.Presencas.ToList();
                return ListarPresenca;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Presenca> ListarPorUsuario(Guid Usuario)
        {
            try
            {
                List<Presenca> ListarPresenca = _context.Presencas.ToList();
                return ListarPresenca;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
