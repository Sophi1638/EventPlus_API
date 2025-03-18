using EventPlus_.Domains;

namespace EventPlus.Interfaces
{
    public interface IComentarioRepository
    {
        //adicionar comentario 
        void Cadastrar(Comentario comentario);
        //excluir 
        void Excluir(Comentario comentario);
        //listar comtario 
        List<Comentario> Listar(Guid id);
        //Lisgar por id
        Comentario BuscarPorId(Guid UsuarioID, Guid EventoID);
    }
}
