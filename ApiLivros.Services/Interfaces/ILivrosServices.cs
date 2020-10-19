using ApiLivros.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ApiLivros.Services.Interfaces
{
    public interface ILivrosServices
    {
        IEnumerable<Produto> ObterLivros(int pageIndex, int pageSize);
        Produto ObterLivroEspecifico(string code);
    }
}
