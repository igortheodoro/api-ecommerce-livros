using ApiLivros.Data.Repositories.Interfaces;
using ApiLivros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiLivros.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AplicacaoContext context;
        public ProdutoRepository(AplicacaoContext context)
        {
            this.context = context;
        }
        public IList<Produto> ObterProdutos(int pageIndex, int pageSize)
        {
            return context.Produtos
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public Produto ObterProdutoEspecifico(string codigo)
        {
            return context.Produtos
                .Where(p => p.Codigo == codigo)
                .AsNoTracking()
                .FirstOrDefault();
        }
    }
}
