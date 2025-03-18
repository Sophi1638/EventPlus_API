using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IEventosRepository
    {
        //Cadastar evento
        void Cadastrar(Evento evento);
        //Atualizar eventos
        void Atualizar(Guid id, Evento evento);
        //Excliuird eventos
        void Excluir(Guid id);
        //Listar eventos
        List<Evento> Listar();
        //Listar eventos por id
        Evento BuscarPorId(Guid id);
        //Listar proximos eventos
        List<Evento> ListarProximosEventos();
    }
}
