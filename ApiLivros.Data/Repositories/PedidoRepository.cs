using ApiLivros.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ApiLivros.Data.Repositories
{
    public class PedidoRepository//:IPedidoRepository
    {
        private readonly AplicacaoContext context;
        private readonly IHttpContextAccessor accessor;

        public PedidoRepository(AplicacaoContext context, IHttpContextAccessor accessor)
        {
            this.context = context;
            this.accessor = accessor;
        }

        //private int? GetPedidoId()
        //{
        //    accessor.HttpContext.Session.;
        //}
    }
}
