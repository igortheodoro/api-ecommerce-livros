using ApiLivros.Data.Repositories.Interfaces;
using ApiLivros.Models;
using ApiLivros.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiLivros.Services
{
    public class LivrosServices:ILivrosServices
    {
        private readonly IProdutoRepository repository;

        public LivrosServices(IProdutoRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Produto> ObterLivros(int pageIndex, int pageSize)
        {
            return repository.ObterProdutos(pageIndex, pageSize);
        }

        public Produto ObterLivroEspecifico(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return null;
            }

            return repository.ObterProdutoEspecifico(code);
        }
    }
}
