using ApiLivros.Dto;
using System.Threading.Tasks;

namespace ApiLivros.Data.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task Registrar(CadastrarUsuarioDto modelo);
    }
}
