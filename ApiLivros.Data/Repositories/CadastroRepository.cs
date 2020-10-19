using ApiLivros.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLivros.Data.Repositories
{
    public class CadastroRepository:ICadastroRepository
    {
        private readonly AplicacaoContext context;
        public CadastroRepository(AplicacaoContext context)
        {
            this.context = context;
        }
    }
}
