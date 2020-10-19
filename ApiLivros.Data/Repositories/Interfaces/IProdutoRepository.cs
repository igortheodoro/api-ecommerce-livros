using ApiLivros.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLivros.Data.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IList<Produto> ObterProdutos(int pageIndex, int pageSize);
        public Produto ObterProdutoEspecifico(string codigo);
    }
}
