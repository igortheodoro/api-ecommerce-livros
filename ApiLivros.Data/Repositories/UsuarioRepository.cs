using ApiLivros.Data.Repositories.Interfaces;
using ApiLivros.Dto;
using ApiLivros.Models;
using Microsoft.AspNetCore.Identity;

namespace ApiLivros.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UserManager<IdentityUser> context;
        public UsuarioRepository(UserManager<IdentityUser> context)
        {
            this.context = context;
        }

        public void Registrar(CadastrarUsuarioDto modelo)
        {
            var usuario = new Usuario();

            usuario.Email = modelo.Email;
            usuario.Bairro = modelo.Bairro;
            usuario.CEP = modelo.CEP;
            usuario.Complemento = modelo.Complemento;
            usuario.Endereco = modelo.Endereco;
            usuario.Municipio = modelo.Municipio;
            usuario.Telefone = modelo.Telefone;
            usuario.UF = modelo.UF;

            context.CreateAsync(usuario, modelo.Senha);
        }
    }
}
