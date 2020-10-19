using ApiLivros.Data.Repositories.Interfaces;
using ApiLivros.Dto;
using ApiLivros.Services.Interfaces;

namespace ApiLivros.Services
{
    public class UsuariosServices : IUsuariosServices
    {
        private readonly IUsuarioRepository repository;
        public UsuariosServices(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        public void Registrar(CadastrarUsuarioDto modelo)
        {
            repository.Registrar(modelo);
        }
    }
}
