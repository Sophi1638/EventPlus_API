using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IPresencaRepository
    {
        //Iscrever-se em evento
        void inscrever(Presenca presenca);
        //Deletarinscrição em evento
        void Deletar(Presenca presenca);
        //Atualizar inscrição
        void Atualizar(Presenca presenca);
        //Listar inscrições
        List<Presenca> listar();
        //Listar inscrições por usuario
        List<Presenca> ListarPorUsuario(Guid id);
        //Listar inscrições por id
    }
}
