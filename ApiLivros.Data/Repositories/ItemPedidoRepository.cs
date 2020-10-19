using ApiLivros.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLivros.Data.Repositories
{
    public class ItemPedidoRepository:IItemPedidoRepository
    {
        private readonly AplicacaoContext context;
        public ItemPedidoRepository(AplicacaoContext context)
        {
            this.context = context;
        }
    }
}
