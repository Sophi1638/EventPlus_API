using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmail(string email, string senha);
    }
}
