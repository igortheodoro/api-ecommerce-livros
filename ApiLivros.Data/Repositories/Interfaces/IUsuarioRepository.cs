using ApiLivros.Dto;

namespace ApiLivros.Data.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        void Registrar(CadastrarUsuarioDto modelo);
    }
}
