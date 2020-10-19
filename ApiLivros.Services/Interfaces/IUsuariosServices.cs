using ApiLivros.Dto;

namespace ApiLivros.Services.Interfaces
{
    public interface IUsuariosServices
    {
        void Registrar(CadastrarUsuarioDto modelo);
    }
}
